using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 提供访问 <see cref="OH_PreferencesValue"/> 对象的接口与数据结构。
/// </summary>
public unsafe partial class PreferencesValue
{
    internal OH_PreferencesValue* NativeInstance;

    /// <summary>
    /// 创建一个 PreferencesValue 实例
    /// </summary>
    /// <param name="nativeValue">原生 PreferencesValue 指针</param>
    internal PreferencesValue(OH_PreferencesValue* nativeValue)
    {
        NativeInstance = nativeValue;
    }

    /// <summary>
    /// 获取当前值的数据类型。
    /// </summary>
    /// <returns>值的数据类型</returns>
    public PreferenceValueType GetValueType()
    {
        if (NativeInstance == null)
        {
            return PreferenceValueType.PREFERENCE_TYPE_NULL;
        }

        return OH_NativeApi.OH_PreferencesValue_GetValueType(NativeInstance);
    }

    /// <summary>
    /// 获取整型值。
    /// </summary>
    /// <param name="value">输出的整型值</param>
    /// <returns>操作结果，0表示成功</returns>
    public int GetInt(ref int value)
    {
        if (NativeInstance == null)
        {
            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM;
        }

        fixed (int* valuePtr = &value)
        {
            return OH_NativeApi.OH_PreferencesValue_GetInt(NativeInstance, valuePtr);
        }
    }

    /// <summary>
    /// 获取布尔值。
    /// </summary>
    /// <param name="value">输出的布尔值</param>
    /// <returns>操作结果，0表示成功</returns>
    public int GetBool(ref bool value)
    {
        if (NativeInstance == null)
        {
            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM;
        }

        fixed (bool* valuePtr = &value)
        {
            return OH_NativeApi.OH_PreferencesValue_GetBool(NativeInstance, valuePtr);
        }
    }

    /// <summary>
    /// 获取字符串值。
    /// </summary>
    /// <param name="value">输出的字符串值</param>
    /// <returns>操作结果，0表示成功</returns>
    public int GetString(ref string value)
    {
        if (NativeInstance == null)
        {
            return (int)PreferencesErrCode.PREFERENCES_ERROR_INVALID_PARAM;
        }

        char* stringPtr = null;
        uint stringLen = 0;

        int result = OH_NativeApi.OH_PreferencesValue_GetString(NativeInstance, &stringPtr, &stringLen);

        if (result == 0 && stringPtr != null)
        {
            // 将 char* 转换为 managed string
            value = Marshal.PtrToStringUTF8((IntPtr)stringPtr, (int)stringLen);
        }

        return result;
    }
}
