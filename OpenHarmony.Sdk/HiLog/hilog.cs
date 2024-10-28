using System.Runtime.InteropServices;

namespace OpenHarmony.Sdk.Native;

public unsafe static partial class Hilog
{
    [LibraryImport("libhilog.so")]
    public  static partial int HiLogPrint(LogType type, LogLevel level, uint domain, sbyte* tag, sbyte* msg);

    public static int OH_LOG_DEBUG(LogType type, string tag, string message)
    {
        var ptag = Marshal.StringToHGlobalAnsi(tag);
        var pmsg = Marshal.StringToHGlobalAnsi(message);
        var ret = HiLogPrint(type, LogLevel.LOG_DEBUG, 0, (sbyte*)ptag, (sbyte*)pmsg);
        Marshal.FreeHGlobal(ptag);
        Marshal.FreeHGlobal(pmsg);
        return ret;
    }
}


public enum LogType
{
    LOG_APP = 0
}

public enum LogLevel
{
    /** Debug level to be used by {@link OH_LOG_DEBUG} */
    LOG_DEBUG = 3,
    /** Informational level to be used by {@link OH_LOG_INFO} */
    LOG_INFO = 4,
    /** Warning level to be used by {@link OH_LOG_WARN} */
    LOG_WARN = 5,
    /** Error level to be used by {@link OH_LOG_ERROR} */
    LOG_ERROR = 6,
    /** Fatal level to be used by {@link OH_LOG_FATAL} */
    LOG_FATAL = 7,
}