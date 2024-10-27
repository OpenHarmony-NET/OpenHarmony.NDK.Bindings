using OpenHarmony.Sdk.HiLog;
using OpenHarmony.Sdk.NodeApi;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OpenHarmony.Net;

public class Class1
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

        NativeApi.napi_module_register(&demoModule);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public unsafe static napi_value* Init(napi_env* env, napi_value* exports)
    {
        var methodName = Marshal.StringToHGlobalAnsi("CSharpAdd");
        napi_property_descriptor[] desc = [
            new (){utf8name = (sbyte*)methodName, name = null, method = &Add, getter = null, setter = null, value = null,  attributes = napi_property_attributes.napi_default, data = null}
            ];
        fixed(napi_property_descriptor* p = desc)
        {
            NativeApi.napi_define_properties(env, exports, 1, p);
        }
        Marshal.FreeHGlobal(methodName);
        return exports;
    }


    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    static unsafe napi_value* Add(napi_env* env, napi_callback_info* info)
    {
        ulong argc = 2;
        napi_value*[] args = [null, null];
        fixed (napi_value** p = args)
        {
            NativeApi.napi_get_cb_info(env, info, &argc, p, null, null);
        }

        napi_valuetype valuetype0;
        NativeApi.napi_typeof(env, args[0], &valuetype0);

        napi_valuetype valuetype1;
        NativeApi.napi_typeof(env, args[1], &valuetype1);

        double value0;
        NativeApi.napi_get_value_double(env, args[0], &value0);

        double value1;
        NativeApi.napi_get_value_double(env, args[1], &value1);

        napi_value* sum;
        NativeApi.napi_create_double(env, value0 + value1, &sum);

        return sum;

    }

}
