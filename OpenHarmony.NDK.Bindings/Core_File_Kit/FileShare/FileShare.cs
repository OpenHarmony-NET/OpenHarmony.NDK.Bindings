using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Core_File_Kit;

public static unsafe partial class FileShare
{
    [LibraryImport("libohfileshare.so")]
    public static partial FileManagement_ErrCode OH_FileShare_PersistPermission(FileShare_PolicyInfo* policies,
        uint policyNum, FileShare_PolicyErrorResult** result, uint* resultNum);

    [LibraryImport("libohfileshare.so")]
    public static partial FileManagement_ErrCode OH_FileShare_RevokePermission(FileShare_PolicyInfo* policies,
        uint policyNum,
        FileShare_PolicyErrorResult** result, uint* resultNum);

    [LibraryImport("libohfileshare.so")]
    public static partial FileManagement_ErrCode OH_FileShare_ActivatePermission(FileShare_PolicyInfo* policies,
        uint policyNum,
        FileShare_PolicyErrorResult** result, uint* resultNum);

    [LibraryImport("libohfileshare.so")]
    public static partial FileManagement_ErrCode OH_FileShare_DeactivatePermission(FileShare_PolicyInfo* policies,
        uint policyNum,
        FileShare_PolicyErrorResult** result, uint* resultNum);

    [LibraryImport("libohfileshare.so")]
    public static partial FileManagement_ErrCode OH_FileShare_CheckPersistentPermission(FileShare_PolicyInfo* policies,
        uint policyNum,
        bool** result, uint* resultNum);

    [LibraryImport("libohfileshare.so")]
    public static partial void OH_FileShare_ReleasePolicyErrorResult(FileShare_PolicyErrorResult* errorResult,
        uint resultNum);
}

public struct FileShare_PolicyErrorResult;

public struct FileShare_PolicyInfo;