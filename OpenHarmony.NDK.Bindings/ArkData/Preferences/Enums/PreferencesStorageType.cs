namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 首选项配置选项的存储模式枚举。
/// </summary>
public enum PreferencesStorageType
{
    /// <summary>
    /// XML存储模式，对数据的操作发生在内存中，调用OH_Preferences_Close时落盘，不支持多进程。
    /// </summary>
    PREFERENCES_STORAGE_XML = 0,

    /// <summary>
    /// GSKV存储模式，对数据的操作实时落盘，可支持多进程
    /// </summary>
    PREFERENCES_STORAGE_GSKV,
}
