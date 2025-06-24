using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.libc;

public static partial class LibcFile
{
    /// <summary>
    /// 打开文件
    /// </summary>
    /// <param name="path"></param>
    /// <param name="flags"></param>
    /// <returns>fd</returns>
    [LibraryImport("libc",EntryPoint = "open",SetLastError = true)]
    public static partial int Open([MarshalAs(UnmanagedType.LPStr)] string path, OpenFlags flags);
    
    /// <summary>
    /// 释放文件
    /// </summary>
    /// <param name="fd"></param>
    [LibraryImport("libc",EntryPoint = "close",SetLastError = true)]
    public static partial void Close(int fd);
}