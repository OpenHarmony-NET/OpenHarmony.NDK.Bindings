using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Sdk.NodeApi;

public unsafe struct napi_module
{
    public int nm_version;
    public uint nm_flags;
    public sbyte* nm_filename;
    public delegate* unmanaged[Cdecl]<napi_env*, napi_value*, napi_value*> napi_addon_register_func;
    public sbyte* nm_modname;
    public void* nm_priv;

    public void* reserved_1;
    public void* reserved_2;
    public void* reserved_3;
    public void* reserved_4;
}


public struct napi_value
{

}
public struct napi_env
{

}
public struct napi_ref
{

}
public struct napi_handle_scope
{

}
public struct napi_escapable_handle_scope
{

}
public struct napi_callback_info
{

}
public struct napi_deferred
{

}