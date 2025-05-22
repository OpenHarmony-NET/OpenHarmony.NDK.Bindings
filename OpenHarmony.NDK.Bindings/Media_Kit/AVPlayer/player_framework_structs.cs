using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace OpenHarmony.NDK.Bindings.Media_Kit.AVPlayer
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MediaKeySession
    {

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct OH_AVFormat
    {

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DRM_MediaKeySystemInfo
    {
        public int PsshCount { get; set; }
        public DRM_PsshInfo PsshInfo { get; set; }
    }
    /// <summary>
    /// uuid的PSSH信息<br/>
    /// https://developer.huawei.com/consumer/cn/doc/harmonyos-references/_d_r_m___pssh_info
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DRM_PsshInfo
    {
        public uint UuId { get; set; }
        public int DataLen { get; set; }
        public uint Data { get; set; }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct OHNativeWindow
    {

    }

    [CustomMarshaller(typeof(AVPlayerCallback), MarshalMode.Default, typeof(AVPlayerCallbackMarshaller))]
    public static unsafe class AVPlayerCallbackMarshaller
    {
        public static AVPlayerCallback ConvertToManaged(IntPtr unmanaged)
        {
            return Marshal.PtrToStructure<AVPlayerCallback>(unmanaged);
        }

        public static IntPtr ConvertToUnmanaged(AVPlayerCallback managed)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<AVPlayerCallback>());
            Marshal.StructureToPtr(managed, ptr, false);
            return ptr;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AVPlayerCallback
    {
        /// <summary>
        /// Info 委托方法
        /// </summary>
        public delegate* unmanaged[Cdecl]<OH_AVPlayer*, AVPlayerOnInfoType, int, void> OH_AVPlayerOnInfo;

        /// <summary>
        /// Error 委托方法<
        /// </summary>
        public delegate* unmanaged[Cdecl]<OH_AVPlayer*, int, nint,void> OH_AVPlayerOnError;
    }
}
