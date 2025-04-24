using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.IPC_Kit;

public static unsafe partial class OHIPCSkeleton
{
    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCSkeleton_JoinWorkThread();

    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCSkeleton_StopWorkThread();

    [LibraryImport("libipc_capi.so")]
    public static partial ulong OH_IPCSkeleton_GetCallingTokenId();

    [LibraryImport("libipc_capi.so")]
    public static partial ulong OH_IPCSkeleton_GetFirstTokenId();

    [LibraryImport("libipc_capi.so")]
    public static partial ulong OH_IPCSkeleton_GetSelfTokenId();

    [LibraryImport("libipc_capi.so")]
    public static partial ulong OH_IPCSkeleton_GetCallingPid();

    [LibraryImport("libipc_capi.so")]
    public static partial ulong OH_IPCSkeleton_GetCallingUid();

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCSkeleton_IsLocalCalling();

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCSkeleton_SetMaxWorkThreadNum(int maxThreadNum);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCSkeleton_ResetCallingIdentity(char** identity, int* len,
        delegate* unmanaged[Cdecl]<int, void*> allocator);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCSkeleton_SetCallingIdentity(char* identity);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCSkeleton_IsHandlingTransaction();
}