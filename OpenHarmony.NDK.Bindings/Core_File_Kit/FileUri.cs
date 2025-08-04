using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Core_File_Kit;

public static unsafe partial class FileUri
{
    [LibraryImport("libohfileuri.so")]
    public static partial FileManagement_ErrCode OH_FileUri_GetUriFromPath(char* path, uint length, char** result);

    [LibraryImport("libohfileuri.so")]
    public static partial FileManagement_ErrCode OH_FileUri_GetPathFromUri(char* uri, uint length, char** result);


    [LibraryImport("libohfileuri.so")]
    public static partial FileManagement_ErrCode OH_FileUri_GetFullDirectoryUri(char* uri, uint length, char** result);


    [LibraryImport("libohfileuri.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OH_FileUri_IsValidUri(char* uri, uint length);


    [LibraryImport("libohfileuri.so")]
    public static partial FileManagement_ErrCode OH_FileUri_GetFileName(char* uri, uint length, char** result);

    public static void Test()
    {
    }
}