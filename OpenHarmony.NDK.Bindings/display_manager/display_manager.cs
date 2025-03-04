using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe static partial class display_manager
{
    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayScaledDensity(float* Density);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayId(ulong* displayId);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayWidth(int* displayWidth);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayHeight(int* displayHeight);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayRotation(NativeDisplayManager_Rotation* displayRotation);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayOrientation(NativeDisplayManager_Orientation* displayOrientation);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayVirtualPixelRatio(float* virtualPixels);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayRefreshRate(uint* refreshRate);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayDensityDpi(int* densityDpi);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayDensityPixels(float* densityPixels);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayDensityXdpi(float* xDpi);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayDensityYdpi(float* yDpi);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_CreateDefaultDisplayCutoutInfo(
        NativeDisplayManager_CutoutInfo** cutoutInfo);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_DestroyDefaultDisplayCutoutInfo(NativeDisplayManager_CutoutInfo* cutoutInfo);

    [LibraryImport("libnative_display_manager.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial  bool OH_NativeDisplayManager_IsFoldable();

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetFoldDisplayMode(
        NativeDisplayManager_FoldDisplayMode* displayMode);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_RegisterDisplayChangeListener(delegate* unmanaged[Cdecl]<ulong, void> displayChangeCallback, uint* listenerIndex);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_UnregisterDisplayChangeListener(uint listenerIndex);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_RegisterFoldDisplayModeChangeListener(
    delegate*unmanaged[Cdecl]<NativeDisplayManager_FoldDisplayMode, void> displayModeChangeCallback, uint* listenerIndex);

    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_UnregisterFoldDisplayModeChangeListener(uint listenerIndex);

}
