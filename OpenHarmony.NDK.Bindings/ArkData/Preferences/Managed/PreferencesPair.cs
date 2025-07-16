using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 提供访问 <see cref="OH_PreferencesPair"/> 对象的接口与数据结构。
/// </summary>
public unsafe partial class PreferencesPair
{
    internal OH_PreferencesPair* NativeInstance;

    /// <summary>
    /// 创建一个 PreferencesPair 实例
    /// </summary>
    /// <param name="nativePairs">原生键值对数组指针</param>
    /// <param name="count">键值对数量</param>
    public PreferencesPair(OH_PreferencesPair* nativePairs, uint count)
    {
        NativeInstance = nativePairs;
        Count = count;
    }

    /// <summary>
    /// 键值对的数量
    /// </summary>
    public uint Count { get; }

    /// <summary>
    /// 获取指定索引位置的键。
    /// </summary>
    /// <param name="index">索引位置</param>
    /// <returns>键的字符串，如果失败返回null</returns>
    public string? GetKey(uint index)
    {
        if (NativeInstance == null || index >= Count)
        {
            return null;
        }

        char* keyPtr = OH_NativeApi.OH_PreferencesPair_GetKey(NativeInstance, index);
        return Marshal.PtrToStringUTF8((IntPtr)keyPtr);
    }

    /// <summary>
    /// 获取指定索引位置的值。
    /// </summary>
    /// <param name="index">索引位置</param>
    /// <returns>值</returns>
    public PreferencesValue? GetValue(uint index)
    {
        if (NativeInstance == null || index >= Count)
        {
            return null;
        }

        OH_PreferencesValue* valuePtr = OH_NativeApi.OH_PreferencesPair_GetPreferencesValue(NativeInstance, index);
        if (valuePtr == null)
        {
            return null;
        }

        return new PreferencesValue(valuePtr);
    }
}

/// <summary>
/// 提供对 <see cref="PreferencesPair"/> 的扩展方法。
/// </summary>
public static class PreferencesPairExtensions
{
    /// <summary>
    /// 获取指定索引位置的值类型。
    /// </summary>
    /// <param name="index">索引位置</param>
    /// <returns>值的类型</returns>
    public unsafe static PreferenceValueType GetValueType(this PreferencesPair pairs, uint index)
    {
        if (pairs == null || pairs.NativeInstance == null || index >= pairs.Count)
        {
            return PreferenceValueType.PREFERENCE_TYPE_NULL;
        }

        OH_PreferencesValue* valuePtr = OH_NativeApi.OH_PreferencesPair_GetPreferencesValue(pairs.NativeInstance, index);
        if (valuePtr == null)
        {
            return PreferenceValueType.PREFERENCE_TYPE_NULL;
        }

        return OH_NativeApi.OH_PreferencesValue_GetValueType(valuePtr);
    }

    /// <summary>
    /// 获取指定索引位置的值。
    /// </summary>
    /// <param name="pairs">PreferencesPair 实例</param>
    /// <param name="index">索引位置</param>
    /// <returns>值</returns>
    public unsafe static (string key, PreferenceValueType type, object? value) GetValue(this PreferencesPair pairs, uint index)
    {
        if (pairs == null || pairs.NativeInstance == null || index >= pairs.Count)
        {
            return (string.Empty, PreferenceValueType.PREFERENCE_TYPE_NULL, null);
        }
        string key = pairs.GetKey(index) ?? string.Empty;
        PreferenceValueType type = pairs.GetValueType(index);
        PreferencesValue? value = pairs.GetValue(index);
        object? valueData = null;
        if (value != null)
        {
            switch (type)
            {
                case PreferenceValueType.PREFERENCE_TYPE_INT:
                    int intValue = 0;
                    value.GetInt(ref intValue);
                    valueData = intValue;
                    break;
                case PreferenceValueType.PREFERENCE_TYPE_BOOL:
                    bool boolValue = false;
                    value.GetBool(ref boolValue);
                    valueData = boolValue;
                    break;
                case PreferenceValueType.PREFERENCE_TYPE_STRING:
                    string stringValue = string.Empty;
                    value.GetString(ref stringValue);
                    valueData = stringValue;
                    break;
            }
        }
        return (key, type, valueData);
    }
}
