using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.IPC_Kit;

public static unsafe partial class OHIPCRemoteObject
{
    [LibraryImport("libipc_capi.so")]
    public static partial OHIPCRemoteStub* OH_IPCRemoteStub_Create(char* descriptor,
        delegate* unmanaged[Cdecl]<int, OHIPCParcel*, OHIPCParcel*, void*, int> requestCallback,
        delegate* unmanaged[Cdecl]<void*, void> destroyCallback, void* userData);

    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCRemoteStub_Destroy(OHIPCRemoteStub* stub);

    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCRemoteProxy_Destroy(OHIPCRemoteProxy* proxy);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCRemoteProxy_SendRequest(OHIPCRemoteProxy* proxy, uint code, OHIPCParcel*
        data, OHIPCParcel* reply, OH_IPC_MessageOption* option);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCRemoteProxy_GetInterfaceDescriptor(OHIPCRemoteProxy* proxy, char** descriptor,
        int* len,
        delegate* unmanaged[Cdecl]<int, void*> allocator);

    [LibraryImport("libipc_capi.so")]
    public static partial OHIPCDeathRecipient* OH_IPCDeathRecipient_Create(
        delegate* unmanaged[Cdecl]<void*, void> deathRecipientCallback,
        delegate* unmanaged[Cdecl]<void*, void> destroyCallback, void* userData);

    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCDeathRecipient_Destroy(OHIPCDeathRecipient* recipient);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCRemoteProxy_AddDeathRecipient(OHIPCRemoteProxy* proxy,
        OHIPCDeathRecipient* recipient);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCRemoteProxy_RemoveDeathRecipient(OHIPCRemoteProxy* proxy,
        OHIPCDeathRecipient* recipient);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCRemoteProxy_IsRemoteDead(OHIPCRemoteProxy* proxy);
}

public struct OH_IPC_MessageOption;

public struct OHIPCRemoteStub;

public struct OHIPCRemoteProxy;

public struct OHIPCDeathRecipient;

public enum OH_IPC_RequestMode
{
    OH_IPC_REQUEST_MODE_SYNC = 0,
    OH_IPC_REQUEST_MODE_ASYNC = 1
}