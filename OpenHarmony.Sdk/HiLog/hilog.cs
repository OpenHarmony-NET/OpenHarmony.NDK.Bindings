using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Sdk.HiLog;

public unsafe static partial class Hilog
{
    [LibraryImport("libhilog.so")]
    public  static partial int HiLogPrint(LogType type, LogLevel level, uint domain, sbyte* tag, sbyte* msg);
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