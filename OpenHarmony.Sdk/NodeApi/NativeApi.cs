using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Sdk.NodeApi;

public static unsafe partial class NativeApi
{
    [LibraryImport("libace_napi.z.so")]
    public static partial void napi_module_register(napi_module* module);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_fatal_exception(napi_env* env, napi_value* err);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_string_utf16(napi_env* env, char* str, ulong length, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_string_utf16(napi_env* env, napi_value* value, char* buf, ulong bufsize, ulong* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_type_tag_object(napi_env* env, napi_value value, napi_type_tag* type_tag);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_run_script_path(napi_env* env, sbyte* path, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_queue_async_work_with_qos(napi_env* env, napi_async_work* work, napi_qos_t qos);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_load_module(napi_env* env, sbyte* path, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_define_properties(napi_env* env, napi_value* @object, ulong property_count, napi_property_descriptor* properties);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_cb_info(napi_env* env, napi_callback_info* cbinfo, ulong* argc, napi_value** argv, napi_value** this_arg, void** data);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_typeof(napi_env* env, napi_value* value, napi_valuetype* result);


    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_double(napi_env* env, napi_value* value, double* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_int32(napi_env* env, napi_value* value, int* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_uint32(napi_env* env, napi_value* value, uint* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_int64(napi_env* env, napi_value* value, long* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_bool(napi_env* env, napi_value* value, bool* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_double(napi_env* env, double value, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_int32(napi_env* env, int value, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_uint32(napi_env* env, uint value, napi_value** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_int64(napi_env* env, long value, napi_value** result);
}
