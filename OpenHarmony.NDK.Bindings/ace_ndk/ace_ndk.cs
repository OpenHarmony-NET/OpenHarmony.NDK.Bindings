using System;
using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe static partial class ace_ndk
{

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetXComponentId(OH_NativeXComponent* component, sbyte* id, ulong* size);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetXComponentSize(OH_NativeXComponent* component, void* window, ulong* width, ulong* height);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetXComponentOffset(OH_NativeXComponent* component, void* window, double* x, double* y);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchEvent(OH_NativeXComponent* component, void* window, OH_NativeXComponent_TouchEvent* touchEvent);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointToolType(OH_NativeXComponent* component, uint pointIndex, OH_NativeXComponent_TouchPointToolType* toolType);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointTiltX(OH_NativeXComponent* component, uint pointIndex, float* tiltX);
    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointTiltY(OH_NativeXComponent* component, uint pointIndex, float* tiltY);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointWindowX(OH_NativeXComponent* component, uint pointIndex, float* windowX);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointWindowY(OH_NativeXComponent* component, uint pointIndex, float* windowY);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointDisplayX(OH_NativeXComponent* component, uint pointIndex, float* displayX);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchPointDisplayY(OH_NativeXComponent* component, uint pointIndex, float* displayY);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetHistoricalPoints(OH_NativeXComponent* component, void* window, int size, OH_NativeXComponent_HistoricalPoint** historicalPoints);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetMouseEvent(OH_NativeXComponent* component,  void* window, OH_NativeXComponent_MouseEvent* mouseEvent);
    
    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterCallback(OH_NativeXComponent* component, OH_NativeXComponent_Callback* callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterMouseEventCallback(OH_NativeXComponent* component, OH_NativeXComponent_MouseEvent_Callback* callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterFocusEventCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, void*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterKeyEventCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, void*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterBlurEventCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, void*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEvent(OH_NativeXComponent* component, OH_NativeXComponent_KeyEvent** keyEvent);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEventAction(OH_NativeXComponent_KeyEvent* keyEvent, OH_NativeXComponent_KeyAction* action);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEventCode(OH_NativeXComponent_KeyEvent* keyEvent, OH_NativeXComponent_KeyCode* code);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEventSourceType(OH_NativeXComponent_KeyEvent* keyEvent, OH_NativeXComponent_EventSourceType* sourceType);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEventDeviceId(OH_NativeXComponent_KeyEvent* keyEvent, long* deviceId);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetKeyEventTimestamp(OH_NativeXComponent_KeyEvent* keyEvent, long* timestamp);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_SetExpectedFrameRateRange(OH_NativeXComponent* component, OH_NativeXComponent_ExpectedRateRange* range);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterOnFrameCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, ulong, ulong, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_UnregisterOnFrameCallback(OH_NativeXComponent* component);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_AttachNativeRootNode(OH_NativeXComponent* component, ArkUI_Node* root);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_DetachNativeRootNode(OH_NativeXComponent* component, ArkUI_NodeHandle root);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterSurfaceShowCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, void*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterSurfaceHideCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, void*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterUIInputEventCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, ArkUI_UIInputEvent*, ArkUI_UIInputEvent_Type, void> callback,  ArkUI_UIInputEvent_Type type);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_SetNeedSoftKeyboard(OH_NativeXComponent* component, [MarshalAs(UnmanagedType.Bool)]bool needSoftKeyboard);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_RegisterOnTouchInterceptCallback(OH_NativeXComponent* component, delegate* unmanaged[Cdecl]<OH_NativeXComponent*, ArkUI_UIInputEvent*, HitTestMode> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetTouchEventSourceType(OH_NativeXComponent* component, int pointId, OH_NativeXComponent_EventSourceType* sourceType);

    [LibraryImport("libace_ndk.z.so")]
    public static partial OH_NativeXComponent* OH_NativeXComponent_GetNativeXComponent(ArkUI_NodeHandle node);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetNativeAccessibilityProvider(OH_NativeXComponent* component, ArkUI_AccessibilityProvider** handle);
}
