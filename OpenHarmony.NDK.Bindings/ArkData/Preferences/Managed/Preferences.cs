using System.Runtime.InteropServices;

using OpenHarmony.NDK.Bindings.Native;

namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 表示首选项数据变更的委托
/// </summary>
/// <param name="changedKeys">发生变更的键列表</param>
public delegate void PreferencesDataChangedHandler(PreferencesPair keys);

/// <summary>
/// 提供访问 <see cref="OH_Preferences"/> 对象的接口与数据结构。
/// </summary>
public unsafe partial class Preferences : IDisposable
{
    /// <summary>
    /// 指向原生Preferences实例的指针。
    /// </summary>
    internal OH_Preferences* NativeInstance;

    /// <summary>
    /// 存储注册的观察者回调
    /// </summary>
    private static readonly Dictionary<ulong, (PreferencesDataChangedHandler Callback, OH_PreferencesDataObserver Observer, IntPtr ObserverHandle)> _observers = [];

    /// <summary>
    /// 用于生成订阅唯一标识符的计数器
    /// </summary>
    private static ulong _nextId = 0;

    /// <summary>
    /// 指示是否已释放资源。
    /// </summary>
    private bool _disposedValue;

    private Preferences(OH_Preferences* preferences)
    {
        NativeInstance = preferences;
    }

    /// <summary>
    /// 打开一个Preferences实例对象并创建指向它的指针。当不再需要使用指针时，请使用OH_Preferences_Close关闭实例对象。
    /// </summary>
    /// <param name="option"></param>
    /// <param name="errCode"></param>
    /// <returns></returns>
    public static Preferences Open(PreferencesOption option, ref int errCode)
    {
        fixed (int* errCodePtr = &errCode)
        {
            var preferences = OH_NativeApi.OH_Preferences_Open(option.NativeInstance, errCodePtr);

            return new Preferences(preferences);
        }
    }

    /// <summary>
    /// 关闭一个Preferences实例对象。
    /// </summary>
    /// <param name="preference"></param>
    /// <returns></returns>
    public int Close()
    {
        return OH_NativeApi.OH_Preferences_Close(NativeInstance);
    }

    /// <summary>
    /// 获取Preferences实例对象中Key对应的整型值。
    /// </summary>
    /// <param name="preference"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public int GetInt(string key, ref int value)
    {
        using var keyPtr = key.ToPointer();
        fixed (int* valuePtr = &value)
        {
            return OH_NativeApi.OH_Preferences_GetInt(NativeInstance, keyPtr, valuePtr);
        }
    }

    /// <summary>
    /// 获取Preferences实例对象中Key对应的布尔值。
    /// </summary>
    /// <param name="preference"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public int GetBool(string key, ref bool value)
    {
        using var keyPtr = key.ToPointer();
        fixed (bool* valuePtr = &value)
        {
            return OH_NativeApi.OH_Preferences_GetBool(NativeInstance, keyPtr, valuePtr);
        }
    }

    /// <summary>
    /// 获取Preferences实例对象中Key对应的字符串。
    /// </summary>
    /// <param name="preference"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public int GetString(string key, ref string value)
    {
        using var keyPtr = key.ToPointer();
        char* stringPtr = null;
        uint stringLen = 0;

        // 调用正确的底层方法
        int result = OH_NativeApi.OH_Preferences_GetString(NativeInstance, key, &stringPtr, &stringLen);

        if (result == 0 && stringPtr != null)
        {
            // 将 char* 转换为 managed string
            value = Marshal.PtrToStringUTF8((IntPtr)stringPtr, (int)stringLen);

            // 释放原生字符串内存
            OH_NativeApi.OH_Preferences_FreeString(stringPtr);
        }

        return result;
    }

    /* 此处由于不向C#传递非托管string, 因此不再需要释放
    /// <summary>
    /// 释放从Preferences实例对象中获取的字符串。
    /// </summary>
    /// <param name=""></param>
    /// <param name=""></param>
    public void OH_Preferences_FreeString(char* @string);
    */

    /// <summary>
    /// 根据Key设置Preferences实例对象中的整型值。
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public int SetInt(string key, int value)
    {
        using var keyPtr = key.ToPointer();
        return OH_NativeApi.OH_Preferences_SetInt(NativeInstance, keyPtr, value);
    }

    /// <summary>
    /// 根据Key设置Preferences实例对象中的布尔值。
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public int SetBool(string key, bool value)
    {
        using var keyPtr = key.ToPointer();
        return OH_NativeApi.OH_Preferences_SetBool(NativeInstance, keyPtr, value);
    }

    /// <summary>
    /// 根据Key设置Preferences实例对象中的字符串。
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public int SetString(string key, string value)
    {
        using var keyPtr = key.ToPointer();
        using var valuePtr = value.ToPointer();
        return OH_NativeApi.OH_Preferences_SetString(NativeInstance, keyPtr, valuePtr);
    }

    /// <summary>
    /// 在Preferences实例对象中删除Key对应的KV数据。
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public int Delete(string key)
    {
        using var keyPtr = key.ToPointer();
        return OH_NativeApi.OH_Preferences_Delete(NativeInstance, keyPtr);
    }

    /// <summary>
    /// 本地回调的静态桥接方法
    /// </summary>
    /// <param name="id"></param>
    /// <param name="context"></param>
    /// <param name="keys"></param>
    /// <param name="count"></param>
    private static unsafe void NativeObserverCallback(ulong id, void* context, OH_PreferencesPair* keys, uint count)
    {
        if (_observers.TryGetValue(id, out var observerData))
        {
            var pairs = new PreferencesPair(keys, count);
            // 调用托管回调
            observerData.Callback?.Invoke(pairs);
        }
    }

    /// <summary>
    /// 对选取的Key注册数据变更订阅。订阅的Key的值发生变更后，在调用OH_Preferences_Close()后触发回调。
    /// </summary>
    /// <param name="callback">当数据变更时要执行的回调</param>
    /// <param name="keys">要监听的键数组</param>
    /// <returns>操作结果代码，0表示成功</returns>
    public unsafe int RegisterDataObserver(PreferencesDataChangedHandler callback, string[] keys)
    {
        if (keys == null || keys.Length == 0 || callback == null)
        {
            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM;
        }

        // 创建唯一的回调标识符
        var id = Interlocked.Increment(ref _nextId);

        // 创建并存储静态委托实例，防止被垃圾回收
        OH_PreferencesDataObserver nativeCallback = new((context, pairs, count) => NativeObserverCallback(id, context, pairs, count));
        var observerHandle = Marshal.GetFunctionPointerForDelegate(nativeCallback);

        // 存储回调和委托句柄以防垃圾回收
        _observers[id] = (callback, nativeCallback, observerHandle);

        // 创建非托管字符串数组
        char*[] unmanagedKeys = new char*[keys.Length];

        try
        {
            // 为每个字符串分配内存并复制
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != null)
                {
                    using var ptr = keys[i].ToPointer();
                    var keyPtr = (char*)ptr.Pointer;
                    int len = keys[i].Length;
                    unmanagedKeys[i] = (char*)Marshal.AllocHGlobal((len + 1) * sizeof(char));
                    for (int j = 0; j < len; j++)
                    {
                        unmanagedKeys[i][j] = keyPtr[j];
                    }
                    unmanagedKeys[i][len] = '\0';
                }
            }

            return OH_NativeApi.OH_Preferences_RegisterDataObserver(NativeInstance, null, observerHandle, unmanagedKeys, (uint)keys.Length);
        }
        catch
        {
            // 发生异常时，清理资源
            if (_observers.TryGetValue(id, out var observerData))
            {
                _observers.Remove(id);
            }
            return -1;
        }
        finally
        {
            // 释放分配的内存
            for (int i = 0; i < unmanagedKeys.Length; i++)
            {
                if (unmanagedKeys[i] != null)
                {
                    Marshal.FreeHGlobal((IntPtr)unmanagedKeys[i]);
                }
            }
        }
    }

    /// <summary>
    /// 取消注册选取Key的数据变更订阅。
    /// </summary>
    /// <param name="callback">之前注册的回调</param>
    /// <param name="keys">要取消监听的键数组</param>
    /// <returns>操作结果代码，0表示成功</returns>
    public unsafe int UnregisterDataObserver(PreferencesDataChangedHandler callback, string[] keys)
    {
        if (keys == null || keys.Length == 0 || callback == null)
        {
            Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "Preferences", $"UnregisterDataObserver: Invalid parameters, {keys == null} {keys?.Length == 0}  {callback == null} ");
            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM;
        }

        // 查找对应的上下文标识符
        ulong? contextToRemove = null;
        foreach (var entry in _observers)
        {
            if (entry.Value.Callback == callback)
            {
                contextToRemove = entry.Key;
                break;
            }
        }

        if (!contextToRemove.HasValue)
        {
            // 未找到匹配的观察者
            return (int)PreferencesErrCode.PREFERENCES_OK;
        }

        // 创建非托管字符串数组
        char*[] unmanagedKeys = new char*[keys.Length];

        try
        {
            // 为每个字符串分配内存并复制
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != null)
                {
                    using var ptr = keys[i].ToPointer();
                    var keyPtr = (char*)ptr.Pointer;
                    int len = keys[i].Length;
                    unmanagedKeys[i] = (char*)Marshal.AllocHGlobal((len + 1) * sizeof(char));
                    for (int j = 0; j < len; j++)
                    {
                        unmanagedKeys[i][j] = keyPtr[j];
                    }
                    unmanagedKeys[i][len] = '\0';

                }
            }

            // 获取与此回调关联的原生委托
            if (_observers.TryGetValue(contextToRemove.Value, out var observerData))
            {
                int result = OH_NativeApi.OH_Preferences_UnregisterDataObserver(NativeInstance, null, observerData.ObserverHandle, unmanagedKeys, (uint)keys.Length);

                // 释放委托句柄并从字典中移除
                _observers.Remove(contextToRemove.Value);
                return result;
            }

            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM; ;
        }
        finally
        {
            // 释放分配的内存
            for (int i = 0; i < unmanagedKeys.Length; i++)
            {
                if (unmanagedKeys[i] != null)
                {
                    Marshal.FreeHGlobal((IntPtr)unmanagedKeys[i]);
                }
            }
        }
    }

    /// <summary>
    /// 校验当前平台是否支持对应存储模式。
    /// </summary>
    /// <param name="type"></param>
    /// <param name="isSupported"></param>
    /// <returns></returns>
    public int IsStorageTypeSupported(PreferencesStorageType type, ref bool isSupported)
    {
        fixed (bool* isSupportedPtr = &isSupported)
        {
            return OH_NativeApi.OH_Preferences_IsStorageTypeSupported(type, isSupportedPtr);
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: 释放托管状态(托管对象)

            }

            // TODO: 释放未托管的资源(未托管的对象)并重写终结器
            // TODO: 将大型字段设置为 null
            _disposedValue = true;
        }
    }

    // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
    ~Preferences()
    {
        // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
