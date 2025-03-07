using System;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe struct napi_module
{
    public int nm_version;
    public uint nm_flags;
    public sbyte* nm_filename;
    public delegate* unmanaged[Cdecl]<napi_env, napi_value, napi_value> napi_addon_register_func;
    public sbyte* nm_modname;
    public void* nm_priv;

    public void* reserved_0;
    public void* reserved_1;
    public void* reserved_2;
    public void* reserved_3;
}

public struct napi_value
{
    public nint Pointer;
}
public struct napi_env
{
    public nint Pointer;
}
public struct napi_ref
{
    public nint Pointer;
}
public struct napi_handle_scope
{
    public nint Pointer;
}
public struct napi_escapable_handle_scope
{
    public nint Pointer;
}
public struct napi_callback_info
{
    public nint Pointer;
}
public struct napi_deferred
{
    public nint Pointer;
}
public struct napi_async_work
{
    public nint Pointer;
}

public struct napi_async_context
{
    public nint Pointer;
}
public enum napi_status
{
    napi_ok,
    napi_invalid_arg,
    napi_object_expected,
    napi_string_expected,
    napi_name_expected,
    napi_function_expected,
    napi_number_expected,
    napi_boolean_expected,
    napi_array_expected,
    napi_generic_failure,
    napi_pending_exception,
    napi_cancelled,
    napi_escape_called_twice,
    napi_handle_scope_mismatch,
    napi_callback_scope_mismatch,
    napi_queue_full,
    napi_closing,
    napi_bigint_expected,
    napi_date_expected,
    napi_arraybuffer_expected,
    napi_detachable_arraybuffer_expected,
    napi_would_deadlock,  // unused
    napi_create_ark_runtime_too_many_envs = 22,
    napi_create_ark_runtime_only_one_env_per_thread = 23,
    napi_destroy_ark_runtime_env_not_exist = 24
}

public struct napi_type_tag
{
    public ulong lower;
    public ulong upper;
}

public enum napi_qos_t
{
    napi_qos_background = 0,
    napi_qos_utility = 1,
    napi_qos_default = 2,
    napi_qos_user_initiated = 3,
}

public unsafe struct napi_property_descriptor
{
    public sbyte* utf8name;
    public napi_value name;
    public delegate* unmanaged[Cdecl]<napi_env, napi_callback_info, napi_value> method;
    public delegate* unmanaged[Cdecl]<napi_env, napi_callback_info, napi_value> getter;
    public delegate* unmanaged[Cdecl]<napi_env, napi_callback_info, napi_value> setter;
    public napi_value value;
    public napi_property_attributes attributes;
    public void* data;
};

public enum napi_property_attributes
{
    napi_default = 0,
    napi_writable = 1 << 0,
    napi_enumerable = 1 << 1,
    napi_configurable = 1 << 2,
    napi_static = 1 << 10,
    napi_default_method = napi_writable | napi_configurable,
    napi_default_jsproperty = napi_writable | napi_enumerable | napi_configurable,
}
public enum napi_valuetype
{
    // ES6 types (corresponds to typeof)
    napi_undefined,
    napi_null,
    napi_boolean,
    napi_number,
    napi_string,
    napi_symbol,
    napi_object,
    napi_function,
    napi_external,
    napi_bigint,
}

public unsafe struct napi_extended_error_info
{
    public sbyte* error_message;
    public void* engine_reserved;
    public uint engine_error_code;
    public napi_status error_code;
}

public enum napi_typedarray_type
{
    napi_int8_array,
    napi_uint8_array,
    napi_uint8_clamped_array,
    napi_int16_array,
    napi_uint16_array,
    napi_int32_array,
    napi_uint32_array,
    napi_float32_array,
    napi_float64_array,
    napi_bigint64_array,
    napi_biguint64_array,
}

public enum napi_key_collection_mode
{
    napi_key_include_prototypes,
    napi_key_own_only
}

public enum napi_key_filter
{
    napi_key_all_properties = 0,
    napi_key_writable = 1,
    napi_key_enumerable = 1 << 1,
    napi_key_configurable = 1 << 2,
    napi_key_skip_strings = 1 << 3,
    napi_key_skip_symbols = 1 << 4
}

public enum napi_key_conversion
{
    napi_key_keep_numbers,
    napi_key_numbers_to_strings
}