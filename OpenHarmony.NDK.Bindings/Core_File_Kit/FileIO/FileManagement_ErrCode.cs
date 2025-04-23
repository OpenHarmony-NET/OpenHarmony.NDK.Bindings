namespace OpenHarmony.NDK.Bindings.Core_File_Kit;

/// <summary>
/// 文件管理模块错误码。
/// </summary>
public enum FileManagement_ErrCode
{
    ERR_OK = 0,

    ERR_PERMISSION_ERROR = 201,

    ERR_INVALID_PARAMETER = 401,

    ERR_DEVICE_NOT_SUPPORTED = 801,

    ERR_EPERM = 13900001,

    ERR_ENOENT = 13900002,

    ERR_ENOMEM = 13900011,

    ERR_UNKNOWN = 13900042
}