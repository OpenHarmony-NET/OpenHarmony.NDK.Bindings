namespace OpenHarmony.NDK.Bindings.libc;

[Flags]
public enum OpenFlags
{
    Read = 0x00,
    Write = 0x01,
    ReadWrite = 0x02,
    Creat = 0x40,
    Trunc = 0x200
}