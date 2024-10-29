using Avalonia.OpenGL.Egl;
using OpenHarmony.Sdk.Native;
using Silk.NET.OpenGLES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Net;

public unsafe static class OpenglExample
{
    public unsafe static napi_value* Init(napi_env* env, napi_value* exports)
    {
        napi_value* exportInstance = null;
        OH_NativeXComponent* nativeXComponent = null;
        int ret = default;
        var xcomponentName = "__NATIVE_XCOMPONENT_OBJ__";
        var xcomponentNamePtr = Marshal.StringToHGlobalAnsi(xcomponentName);
        if (ace_napi.napi_get_named_property(env, exports, (sbyte*)xcomponentNamePtr, &exportInstance) == napi_status.napi_ok)
        {
            if (ace_napi.napi_unwrap(env, exportInstance, (void**)&nativeXComponent) == napi_status.napi_ok)
            {
                var p = Marshal.AllocHGlobal(sizeof(OH_NativeXComponent_Callback));
                ref var g_ComponentCallback = ref Unsafe.AsRef<OH_NativeXComponent_Callback>((void*)p);
                g_ComponentCallback.OnSurfaceCreated = &OnSurfaceCreated;
                g_ComponentCallback.OnSurfaceChanged = &OnSurfaceChanged;
                g_ComponentCallback.OnSurfaceDestroyed = &OnSurfaceDestroyed;
                g_ComponentCallback.DispatchTouchEvent = &DispatchTouchEvent;
                ace_ndk.OH_NativeXComponent_RegisterCallback(nativeXComponent, (OH_NativeXComponent_Callback*)p);
            }
        }
        Marshal.FreeHGlobal(xcomponentNamePtr);
        return exports;
    }


    static GL gl;
    static nint display;
    static nint surface;
    static EglInterface egl;
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void OnSurfaceCreated(OH_NativeXComponent* component, void* window)
    {
        ace_ndk.OH_NativeXComponent_RegisterOnFrameCallback(component, &OnSurfaceRendered);
        Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "OnSurfaceCreated");

        egl = new EglInterface("libEGL.so");

        display = egl.GetDisplay(0);
        if (egl.Initialize(display, out var major, out var minor) == false)
        {
            Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "egl.Initialize fail");
            return;
        }
        int[] attributes = [0x3033, 0x0004, 0x3024, 8, 0x3023, 8, 0x3022, 8, 0x3021, 8, 0x3040, 0x0004, 0x3038];
        if (egl.ChooseConfig(display, attributes, out var configs, 1, out var choosenConfig) == false)
        {
            Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "egl.ChooseConfig fail");
            return;
        }
        int[] winAttribs = [0x309D, 0x3089, 0x3038];
        surface = egl.CreateWindowSurface(display, configs, (nint)window, winAttribs);
        if (surface == 0)
        {
            Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "egl.CreateWindowSurface fail");
            return;
        }
        int[] attrib3_list = [0x3098, 2, 0x3038];
        int sharedEglContext = 0;
        var context = egl.CreateContext(display, configs, sharedEglContext, attrib3_list);
        if (egl.MakeCurrent(display, surface, surface, context) == false)
        {
            Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "egl.MakeCurrent fail");
            return;
        }

        Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "egl init success");
        gl = GL.GetApi(name =>
        {
            var ptr = Marshal.StringToHGlobalAnsi(name);
            var fun = egl.GetProcAddress(ptr);
            Marshal.FreeHGlobal(ptr);
            return fun;
        });
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void OnSurfaceRendered(OH_NativeXComponent* component, ulong timestamp, ulong targetTimestamp)
    {
        // Hilog.OH_LOG_DEBUG(LogType.LOG_APP, "CSharp", "OnRender");
        gl.ClearColor(Color.Blue);
        gl.Clear(ClearBufferMask.ColorBufferBit);
        egl.SwapBuffers(display, surface);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void OnSurfaceChanged(OH_NativeXComponent* component, void* window)
    {

    }
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void OnSurfaceDestroyed(OH_NativeXComponent* component, void* window)
    {

    }
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static void DispatchTouchEvent(OH_NativeXComponent* component, void* window)
    {

    }
}
