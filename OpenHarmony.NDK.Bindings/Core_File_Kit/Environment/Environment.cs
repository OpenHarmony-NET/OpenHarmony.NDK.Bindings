using System.Runtime.InteropServices;
using OpenHarmony.NDK.Bindings.Native;

namespace OpenHarmony.NDK.Bindings.Core_File_Kit;

public static unsafe partial class Environment
{
    [LibraryImport("llibohenvironment.so")]
    public static partial FileManagement_ErrCode* OH_Environment_GetUserDownloadDir(char** result);

    [LibraryImport("llibohenvironment.so")]
    public static partial FileManagement_ErrCode OH_Environment_GetUserDesktopDir(char** result);

    [LibraryImport("llibohenvironment.so")]
    public static partial FileManagement_ErrCode OH_Environment_GetUserDocumentDir(char** result);
}