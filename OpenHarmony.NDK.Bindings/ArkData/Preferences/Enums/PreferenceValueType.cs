namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 定义PreferencesValue的数据类型。
/// </summary>
public enum PreferenceValueType
{
    /// <summary>
    /// 空类型。
    /// </summary>
    PREFERENCE_TYPE_NULL = 0,

    /// <summary>
    /// 整型类型。
    /// </summary>
    PREFERENCE_TYPE_INT,

    /// <summary>
    /// 布尔类型。
    /// </summary>
    PREFERENCE_TYPE_BOOL,

    /// <summary>
    /// 字符串类型。
    /// </summary>
    PREFERENCE_TYPE_STRING,

    /// <summary>
    /// 结束类型。
    /// </summary>
    PREFERENCE_TYPE_BUTT
}
