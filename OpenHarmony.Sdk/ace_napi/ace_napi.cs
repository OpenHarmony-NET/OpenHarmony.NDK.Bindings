using System;
using System.Runtime.InteropServices;

namespace OpenHarmony.Sdk.Native;

public static unsafe partial class ace_napi
{
    [LibraryImport("libace_napi.z.so")]
    public static partial void napi_module_register(napi_module* module);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_fatal_exception(napi_env env, napi_value err);

    [LibraryImport("libace_napi.z.so")]
    public static partial void napi_fatal_error(sbyte* location, ulong location_len, sbyte* message, ulong message_len);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_async_init(napi_env env, napi_value async_resource, napi_value async_resource_name, napi_async_context* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_make_callback(napi_env env, napi_async_context async_context, napi_value recv, napi_value func, ulong argc, napi_value* argv, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_buffer(napi_env env, ulong length, void** data, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_external_buffer(napi_env env, ulong length, void* data, delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb, void* finalize_hint, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_buffer_copy(napi_env env, ulong length, void* data, void** result_data, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_buffer(napi_env env, napi_value value, bool* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_buffer_info(napi_env env, napi_value value, void** data, ulong* length);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_async_work(napi_env env,
                                   napi_value async_resource,
                                   napi_value async_resource_name,
                                   delegate* unmanaged[Cdecl]<napi_env, void*, void> execute,
                                   delegate* unmanaged[Cdecl]<napi_env, napi_status, void*, void> complete,
                                   void* data,
                                   napi_async_work* result);



    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_last_error_info(napi_env env, napi_extended_error_info** result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_undefined(napi_env env, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_null(napi_env env, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_global(napi_env env, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_boolean(napi_env env, [MarshalAs(UnmanagedType.Bool)]bool value, napi_value* result);


    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_object(napi_env env, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_array(napi_env env, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_array_with_length(napi_env env, ulong length, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_double(napi_env env, double value, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_int32(napi_env env, int value, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_uint32(napi_env env,
                                               uint value,
                                               napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_int64(napi_env env,
                                              long value,
                                              napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_string_latin1(napi_env env,
                                                  sbyte* str,
                                                  ulong length,
                                                  napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_string_utf8(napi_env env,
                                                sbyte* str,
                                                ulong length,
                                                napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_string_utf16(napi_env env,
                                                 char* str,
                                                 ulong length,
                                                 napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_symbol(napi_env env,
                                               napi_value description,
                                               napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_function(napi_env env,
                                             sbyte* utf8name,
                                             ulong length,
                                             delegate* unmanaged[Cdecl]<napi_env, napi_callback_info, napi_value> cb,
                                             void* data,
                                             napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_error(napi_env env,
                                          napi_value code,
                                          napi_value msg,
                                          napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_type_error(napi_env env,
                                                   napi_value code,
                                                   napi_value msg,
                                                   napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_range_error(napi_env env,
                                                    napi_value code,
                                                    napi_value msg,
                                                    napi_value* result);



    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_typeof(napi_env env,
                                    napi_value value,
                                    napi_valuetype* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_double(napi_env env,
                                                  napi_value value,
                                                  double* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_int32(napi_env env,
                                                 napi_value value,
                                                 int* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_uint32(napi_env env,
                                                  napi_value value,
                                                  uint* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_int64(napi_env env,
                                                 napi_value value,
                                                 long* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_bool(napi_env env,
                                                napi_value value,
                                                bool* result);

    // Copies LATIN-1 encoded bytes from a string into a buffer.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_string_latin1(napi_env env,
                                                         napi_value value,
                                                         char* buf,
                                                         ulong bufsize,
                                                         ulong* result);

    // Copies UTF-8 encoded bytes from a string into a buffer.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_string_utf8(napi_env env,
                                                       napi_value value,
                                                       sbyte* buf,
                                                       ulong bufsize,
                                                       ulong* result);

    // Copies UTF-16 encoded bytes from a string into a buffer.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_string_utf16(napi_env env,
                                                        napi_value value,
                                                        char* buf,
                                                        ulong bufsize,
                                                        ulong* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_coerce_to_bool(napi_env env,
                                            napi_value value,
                                            napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_coerce_to_number(napi_env env,
                                                  napi_value value,
                                                  napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_coerce_to_object(napi_env env,
                                                  napi_value value,
                                                  napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_coerce_to_string(napi_env env,
                                                  napi_value value,
                                                  napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_prototype(napi_env env,
                                           napi_value @object,
                                           napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_property_names(napi_env env,
                                                    napi_value @object,
                                                    napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_set_property(napi_env env,
                                              napi_value @object,
                                              napi_value key,
                                              napi_value value);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_has_property(napi_env env,
                                              napi_value @object,
                                              napi_value key,
                                              bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_property(napi_env env,
                                              napi_value @object,
                                              napi_value key,
                                              napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_delete_property(napi_env env,
                                                 napi_value @object,
                                                 napi_value key,
                                                 bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_has_own_property(napi_env env,
                                                  napi_value @object,
                                                  napi_value key,
                                                  bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_set_named_property(napi_env env,
                                              napi_value @object,
                                          sbyte* utf8name,
                                          napi_value value);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_has_named_property(napi_env env,
                                          napi_value @object,
                                          sbyte* utf8name,
                                          bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_named_property(napi_env env,
                                              napi_value @object,
                                          sbyte* utf8name,
                                          napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_set_element(napi_env env,
                                         napi_value @object,
                                         uint index,
                                         napi_value value);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_has_element(napi_env env,
                                             napi_value @object,
                                             uint index,
                                             bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_element(napi_env env,
                                             napi_value @object,
                                             uint index,
                                             napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_delete_element(napi_env env,
                                                napi_value @object,
                                                uint index,
                                                bool* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_define_properties(napi_env env,
                       napi_value @object,
                       ulong property_count,
                       napi_property_descriptor* properties);

    // Methods to work with Arrays
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_array(napi_env env,
                                          napi_value value,
                                          bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_array_length(napi_env env,
                                                  napi_value value,
                                                  uint* result);

    // Methods to compare values
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_strict_equals(napi_env env,
                                               napi_value lhs,
                                               napi_value rhs,
                                               bool* result);

    // Methods to work with Functions
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_call_function(napi_env env,
                                               napi_value recv,
                                               napi_value func,
                                               ulong argc,
                                               napi_value* argv,
                                               napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_new_instance(napi_env env,
                                          napi_value constructor,
                                          ulong argc,
                                          napi_value* argv,
                                          napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_instanceof(napi_env env,
                                        napi_value @object,
                                        napi_value constructor,
                                        bool* result);
    // Methods to work with napi_callbacks

    // Gets all callback info in a single call. (Ugly, but faster.)
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_cb_info(
        napi_env env,               // [in] NAPI environment handle
        napi_callback_info cbinfo,  // [in] Opaque callback-info handle
        ulong* argc,      // [in-out] Specifies the size of the provided argv array
                           // and receives the actual count of args.
        napi_value* argv,  // [out] Array of values
        napi_value* this_arg,  // [out] Receives the JS 'this' arg for the call
        void** data);          // [out] Receives the data pointer for the callback.

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_new_target(napi_env env,
                                                napi_callback_info cbinfo,
                                                napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_define_class(napi_env env,
                  sbyte* utf8name,
                  ulong length,
                  delegate* unmanaged[Cdecl]<napi_env, napi_callback_info, napi_value> constructor,
                  void* data,
                  ulong property_count,
                  napi_property_descriptor* properties,
                  napi_value* result);

// Methods to work with external data objects
[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_wrap(napi_env env,
                                  napi_value js_object,
                                  void* native_object,
                                  delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb,
                                  void* finalize_hint,
                                  napi_ref* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_unwrap(napi_env env,
                                        napi_value js_object,
                                        void** result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_remove_wrap(napi_env env,
                                             napi_value js_object,
                                             void** result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_external(napi_env env,
                                                 void* data,
                                                 delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb,
                                                 void* finalize_hint,
                                                 napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_external(napi_env env,
                                                    napi_value value,
                                                    void** result);

    // Methods to control object lifespan

    // Set initial_refcount to 0 for a weak reference, >0 for a strong reference.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_reference(napi_env env,
                                                  napi_value value,
                                                  int initial_refcount,
                                                  napi_ref* result);

    // Deletes a reference. The referenced value is released, and may
    // be GC'd unless there are other references to it.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_delete_reference(napi_env env, napi_ref @ref);

    // Increments the reference count, optionally returning the resulting count.
    // After this call the  reference will be a strong reference because its
    // refcount is >0, and the referenced object is effectively "pinned".
    // Calling this when the refcount is 0 and the object is unavailable
    // results in an error.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_reference_ref(napi_env env,
                                               napi_ref @ref,
                                               int* result);

    // Decrements the reference count, optionally returning the resulting count.
    // If the result is 0 the reference is now weak and the object may be GC'd
    // at any time if there are no other references. Calling this when the
    // refcount is already 0 results in an error.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_reference_unref(napi_env env,
                                                 napi_ref @ref,
                                                 int* result);

    // Attempts to get a referenced value. If the reference is weak,
    // the value might no longer be available, in that case the call
    // is still successful but the result is NULL.
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_reference_value(napi_env env,
                                                     napi_ref @ref,
                                                     napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_open_handle_scope(napi_env env,
                                                   napi_handle_scope* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_close_handle_scope(napi_env env,
                                                    napi_handle_scope scope);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status
napi_open_escapable_handle_scope(napi_env env,
                                 napi_escapable_handle_scope* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status
napi_close_escapable_handle_scope(napi_env env,
                                  napi_escapable_handle_scope scope);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_escape_handle(napi_env env,
                                               napi_escapable_handle_scope scope,
                                               napi_value escapee,
                                               napi_value* result);

    // Methods to support error handling
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_throw(napi_env env, napi_value error);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_throw_error(napi_env env,
                                         sbyte* code,
                                         sbyte* msg);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_throw_type_error(napi_env env,
                                         sbyte* code,
                                         sbyte* msg);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_throw_range_error(napi_env env,
                                         sbyte* code,
                                         sbyte* msg);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_error(napi_env env,
                                          napi_value value,
                                          bool* result);

    // Methods to support catching exceptions
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_exception_pending(napi_env env, bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_and_clear_last_exception(napi_env env,
                                                              napi_value* result);

    // Methods to work with array buffers and typed arrays
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_arraybuffer(napi_env env,
                                                napi_value value,
                                                bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_arraybuffer(napi_env env,
                                                    ulong byte_length,
                                                    void** data,
                                                    napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status
napi_create_external_arraybuffer(napi_env env,
                                 void* external_data,
                                 ulong byte_length,
                                 delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb,
                                 void* finalize_hint,
                                 napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_arraybuffer_info(napi_env env,
                                                      napi_value arraybuffer,
                                                      void** data,
                                                      ulong* byte_length);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_typedarray(napi_env env,
                                               napi_value value,
                                               bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_typedarray(napi_env env,
                                                   napi_typedarray_type type,
                                                   ulong length,
                                                   napi_value arraybuffer,
                                                   ulong byte_offset,
                                                   napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_typedarray_info(napi_env env,
                                                     napi_value typedarray,
                                                     napi_typedarray_type* type,
                                                     ulong* length,
                                                     void** data,
                                                     napi_value* arraybuffer,
                                                     ulong* byte_offset);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_dataview(napi_env env,
                                                 ulong length,
                                                 napi_value arraybuffer,
                                                 ulong byte_offset,
                                                 napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_dataview(napi_env env,
                                             napi_value value,
                                             bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_dataview_info(napi_env env,
                                                   napi_value dataview,
                                                   ulong* bytelength,
                                                   void** data,
                                                   napi_value* arraybuffer,
                                                   ulong* byte_offset);

    // version management
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_version(napi_env env, int* result);

    // Promises
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_promise(napi_env env,
                                                napi_deferred* deferred,
                                                napi_value* promise);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_resolve_deferred(napi_env env,
                                                  napi_deferred deferred,
                                                  napi_value resolution);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_reject_deferred(napi_env env,
                                                 napi_deferred deferred,
                                                 napi_value rejection);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_promise(napi_env env,
                                            napi_value value,
                                            bool* is_promise);

    // Running a script
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_run_script(napi_env env,
                                            napi_value script,
                                            napi_value* result);

    // Memory management
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_adjust_external_memory(napi_env env,
                                                        long change_in_bytes,
                                                        long* adjusted_value);


// Dates
[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_date(napi_env env,
                                         double time,
                                         napi_value* result);

[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_date(napi_env env,
                                     napi_value value,
                                     bool* is_date);

[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_date_value(napi_env env,
                                            napi_value value,
                                            double* result);

// Add finalizer for pointer
[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_add_finalizer(napi_env env,
                                           napi_value js_object,
                                           void* native_object,
                                           delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb,
                                           void* finalize_hint,
                                           napi_ref* result);

    // BigInt
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_bigint_int64(napi_env env,
                                                     long value,
                                                     napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_bigint_uint64(napi_env env,
                                                      ulong value,
                                                      napi_value* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_create_bigint_words(napi_env env,
                                                     int sign_bit,
                                                     ulong word_count,
                                                 ulong* words,
                                                 napi_value* result);
[LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_bigint_int64(napi_env env,
                                                    napi_value value,
                                                    long* result,
                                                    bool* lossless);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_bigint_uint64(napi_env env,
                                                         napi_value value,
                                                         ulong* result,
                                                         bool* lossless);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_value_bigint_words(napi_env env,
                                                        napi_value value,
                                                        int* sign_bit,
                                                        ulong* word_count,
                                                        ulong* words);

    // Object
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_all_property_names(napi_env env,
                            napi_value @object,
                            napi_key_collection_mode key_mode,
                            napi_key_filter key_filter,
                            napi_key_conversion key_conversion,
                            napi_value* result);

    // Instance data
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_set_instance_data(napi_env env,
                                                   void* data,
                                                   delegate* unmanaged[Cdecl]<napi_env, void*, void*, void> finalize_cb,
                                                   void* finalize_hint);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_get_instance_data(napi_env env,
                                                   void** data);

    // ArrayBuffer detaching
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_detach_arraybuffer(napi_env env,
                                                    napi_value arraybuffer);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_is_detached_arraybuffer(napi_env env,
                                                         napi_value value,
                                                         bool* result);
    // Type tagging
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_type_tag_object(napi_env env,
                                                 napi_value value,
                                             napi_type_tag* type_tag);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_check_object_type_tag(napi_env env,
                           napi_value value,
                           napi_type_tag* type_tag,
                           bool* result);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_object_freeze(napi_env env,
                                               napi_value @object);
    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_object_seal(napi_env env,
                                             napi_value @object);


    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_run_script_path(napi_env env, sbyte* path, napi_value* result);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_queue_async_work_with_qos(napi_env env, napi_async_work work, napi_qos_t qos);

    [LibraryImport("libace_napi.z.so")]
    public static partial napi_status napi_load_module(napi_env env, sbyte* path, napi_value* result);

}
