using System.Runtime.CompilerServices;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenHarmony.NDK.Bindings.Native;
[assembly: DisableRuntimeMarshalling]


namespace OpenHarmony.NDK.Bindings.IPC_Kit;

public unsafe partial struct OHIPCParcel
{
    [LibraryImport("libipc_capi.so")]
    public static partial OHIPCParcel* OH_IPCParcel_Create();

    [LibraryImport("libipc_capi.so")]
    public static partial void OH_IPCParcel_Destroy(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_GetDataSize(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_GetWritableBytes(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_GetReadableBytes(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_GetReadPosition(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_GetWritePosition(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_RewindReadPosition(OHIPCParcel* parcel, uint newReadPos);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_RewindWritePosition(OHIPCParcel* parcel, uint newWritePos);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteInt8(OHIPCParcel* parcel, char value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadInt8(OHIPCParcel* parcel, char* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteInt16(OHIPCParcel* parcel, short value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadInt16(OHIPCParcel* parcel, short* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteInt32(OHIPCParcel* parcel, int value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadInt32(OHIPCParcel* parcel, int* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteInt64(OHIPCParcel* parcel, long value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadInt64(OHIPCParcel* parcel, long* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteFloat(OHIPCParcel* parcel, float value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadFloat(OHIPCParcel* parcel, float* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteDouble(OHIPCParcel* parcel, double value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadDouble(OHIPCParcel* parcel, double* value);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteString(OHIPCParcel* parcel, char* str);

    [LibraryImport("libipc_capi.so")]
    public static partial char* OH_IPCParcel_ReadString(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteBuffer(OHIPCParcel* parcel, char* buffer, int len);

    [LibraryImport("libipc_capi.so")]
    public static partial char* OH_IPCParcel_ReadBuffer(OHIPCParcel* parcel, int len);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteRemoteStub(OHIPCParcel* parcel, OHIPCRemoteStub* stub);

    [LibraryImport("libipc_capi.so")]
    public static partial OHIPCRemoteStub* OH_IPCParcel_ReadRemoteStub(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteRemoteProxy(OHIPCParcel* parcel, OHIPCRemoteProxy* proxy);

    [LibraryImport("libipc_capi.so")]
    public static partial OHIPCRemoteProxy* OH_IPCParcel_ReadRemoteProxy(OHIPCParcel* parcel);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteFileDescriptor(OHIPCParcel* parcel, int fd);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadFileDescriptor(OHIPCParcel* parcel, int* fd);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_Append(OHIPCParcel* parcel, OHIPCParcel* data);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_WriteInterfaceToken(OHIPCParcel* parcel, char* token);

    [LibraryImport("libipc_capi.so")]
    public static partial int OH_IPCParcel_ReadInterfaceToken(OHIPCParcel* parcel, char** token, int* len,
        delegate* unmanaged[Cdecl]<int, void*> allocator);
}