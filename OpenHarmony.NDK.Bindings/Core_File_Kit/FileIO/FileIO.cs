using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Core_File_Kit;

public static unsafe partial class FileIO
{
    [LibraryImport("libohfileio.so")]
    public static partial FileManagement_ErrCode OH_FileIO_GetFileLocation(char* uri, int uriLength,
        FileIO_FileLocation* location);
}