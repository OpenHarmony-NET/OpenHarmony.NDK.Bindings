namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 声明首选项模块统一使用的错误码信息。
/// </summary>
public enum PreferencesErrCode
{
    /// <summary>
    /// 操作执行成功。
    /// </summary>
    PREFERENCES_OK = 0,

    /// <summary>
    /// 参数不合法。
    /// </summary>
    PREFERENCES_ERROR_INVALID_PARAM = 401,

    /// <summary>
    /// 系统能力不支持。
    /// </summary>
    PREFERENCES_ERROR_NOT_SUPPORTED = 801,

    /// <summary>
    /// 基准错误码。
    /// </summary>
    PREFERENCES_ERROR_BASE = 15500000,

    /// <summary>
    /// 删除文件失败。
    /// </summary>
    PREFERENCES_ERROR_DELETE_FILE = 15500010,

    /// <summary>
    /// 存储异常。
    /// </summary>
    PREFERENCES_ERROR_STORAGE = 15500011,

    /// <summary>
    /// 申请内存失败。
    /// </summary>
    PREFERENCES_ERROR_MALLOC = 15500012,

    /// <summary>
    /// Key不存在。
    /// </summary>
    PREFERENCES_ERROR_KEY_NOT_FOUND = 15500013,

    /// <summary>
    /// 获取数据变更订阅服务失败。
    /// </summary>
    PREFERENCES_ERROR_GET_DATAOBSMGRCLIENT = 15500019
}
