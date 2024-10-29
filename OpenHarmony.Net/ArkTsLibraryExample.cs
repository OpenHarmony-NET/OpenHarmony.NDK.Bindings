using OpenHarmony.Sdk.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Net;

public unsafe static class ArkTsLibraryExample
{
    public unsafe static napi_value* Init(napi_env* env, napi_value* exports)
    {
        var methodName = Marshal.StringToHGlobalAnsi("CSharpAdd");
        napi_property_descriptor[] desc = [
            new (){utf8name = (sbyte*)methodName, name = null, method = &Add, getter = null, setter = null, value = null,  attributes = napi_property_attributes.napi_default, data = null}
            ];
        fixed (napi_property_descriptor* p = desc)
        {
            ace_napi.napi_define_properties(env, exports, 1, p);
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
            ace_napi.napi_get_cb_info(env, info, &argc, p, null, null);
        }

        napi_valuetype valuetype0;
        ace_napi.napi_typeof(env, args[0], &valuetype0);

        napi_valuetype valuetype1;
        ace_napi.napi_typeof(env, args[1], &valuetype1);

        double value0;
        ace_napi.napi_get_value_double(env, args[0], &value0);

        double value1;
        ace_napi.napi_get_value_double(env, args[1], &value1);

        napi_value* sum;
        ace_napi.napi_create_double(env, value0 + value1, &sum);

        return sum;

    }
}
