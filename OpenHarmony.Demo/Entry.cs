using OpenHarmony.NDK.Bindings.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenHarmony.Net;

public class Entry
{
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)], EntryPoint = "RegisterEntryModule")]
    public unsafe static void RegisterEntryModule()
    {
        var tag = Marshal.StringToHGlobalAnsi("CSharp");
        var msg = Marshal.StringToHGlobalAnsi("Hello CSharp");

        Hilog.HiLogPrint(LogType.LOG_APP, LogLevel.LOG_ERROR, 0xFF00, (sbyte*)tag, (sbyte*)msg);

        Marshal.FreeHGlobal(tag);
        Marshal.FreeHGlobal(msg);
        var s = "entry";

        napi_module demoModule = new napi_module
        {
            nm_version = 1,
            nm_flags = 0,
            nm_filename = null,
            nm_modname = (sbyte*)Marshal.StringToHGlobalAnsi(s),
            nm_priv = null,
            napi_addon_register_func = &Init,
            reserved_0 = null,
            reserved_1 = null,
            reserved_2 = null,
            reserved_3 = null,
        };

        node_api.napi_module_register(&demoModule);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public unsafe static napi_value Init(napi_env env, napi_value exports)
    {
        ArkTsLibraryExample.Init(env, exports);
        OpenglExample.Init(env, exports);

        return exports;
    }



}
