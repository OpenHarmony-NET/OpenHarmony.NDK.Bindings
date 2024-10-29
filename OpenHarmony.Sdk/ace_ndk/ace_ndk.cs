using System.Runtime.InteropServices;

namespace OpenHarmony.Sdk.Native;

public unsafe static partial class ace_ndk
{
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
    public static partial int OH_NativeXComponent_GetXComponentSize(OH_NativeXComponent* component, void* window, ulong* width, ulong* height);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetXComponentOffset(OH_NativeXComponent* component, void* window, double* x, double* y);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_NativeXComponent_GetXComponentId(OH_NativeXComponent* component, sbyte* id, ulong* size);




}
