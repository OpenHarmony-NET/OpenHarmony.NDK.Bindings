namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 提供访问 <see cref="OH_NativeApi.OH_PreferencesOption"/> 对象的接口与数据结构。
/// </summary>
public unsafe partial class PreferencesOption : IDisposable
{
    internal OH_PreferencesOption* NativeInstance;
    private bool _disposedValue;

    /// <summary>
    /// 创建一个Preferences配置选项。当不再需要使用时，请使用Destroy销毁实例对象，否则会导致内存泄漏。
    /// </summary>
    public PreferencesOption()
    {
        NativeInstance = OH_NativeApi.OH_PreferencesOption_Create();
    }

    /// <summary>
    /// 设置Preferences配置选项的文件名称。
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public int SetFileName(string fileName)
    {
        ObjectDisposedException.ThrowIf(_disposedValue, this);

        fixed (char* fileNameBuffer = fileName)
        {
            return OH_NativeApi.OH_PreferencesOption_SetFileName(NativeInstance, fileNameBuffer);
        }
    }

    /// <summary>
    /// 设置Preferences配置选项的包名称。
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns></returns>
    public int SetBundleName(string bundleName)
    {
        ObjectDisposedException.ThrowIf(_disposedValue, this);

        fixed (char* bundleNameBuffer = bundleName)
        {
            return OH_NativeApi.OH_PreferencesOption_SetBundleName(NativeInstance, bundleNameBuffer);
        }
    }

    /// <summary>
    /// 设置Preferences配置选项的应用组ID。设置应用组ID后，会指定在此应用组ID对应的沙箱路径下创建Preferences实例。应用组ID需要向应用市场获取，暂不支持。当传入的应用组ID为空字符串时，默认在本应用沙箱目录下创建Preferences实例。
    /// </summary>
    /// <param name="dataGroupId"></param>
    /// <returns></returns>
    public int SetDataGroupId(string dataGroupId)
    {
        ObjectDisposedException.ThrowIf(_disposedValue, this);

        fixed (char* dataGroupIdBuffer = dataGroupId)
        {
            return OH_NativeApi.OH_PreferencesOption_SetDataGroupId(NativeInstance, dataGroupIdBuffer);
        }
    }

    /// <summary>
    /// 设置Preferences实例的存储模式。
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public int SetStorageType(PreferencesStorageType type)
    {
        ObjectDisposedException.ThrowIf(_disposedValue, this);

        return OH_NativeApi.OH_PreferencesOption_SetStorageType(NativeInstance, type);
    }

    /// <summary>
    /// 销毁Preferences配置选项实例。
    /// </summary>
    /// <returns></returns>
    public int Destroy()
    {
        if (null != NativeInstance)
        {
            var retCode = OH_NativeApi.OH_PreferencesOption_Destroy(NativeInstance);
            NativeInstance = null;
            return retCode;
        }

        return 0;
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

            if (null != NativeInstance)
            {
                _ = OH_NativeApi.OH_PreferencesOption_Destroy(NativeInstance);
                NativeInstance = null;
            }

            _disposedValue = true;
        }
    }

    // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
    ~PreferencesOption()
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
