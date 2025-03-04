using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.NDK.Bindings.Native;

public enum NativeDisplayManager_ErrorCode
{
    /** @error Operation is successful */
    DISPLAY_MANAGER_OK = 0,

    /** @error Operation no permission */
    DISPLAY_MANAGER_ERROR_NO_PERMISSION = 201,

    /** @error Operation not system app */
    DISPLAY_MANAGER_ERROR_NOT_SYSTEM_APP = 202,

    /** @error Operation invalid param */
    DISPLAY_MANAGER_ERROR_INVALID_PARAM = 401,

    /** @error Operation device not supported */
    DISPLAY_MANAGER_ERROR_DEVICE_NOT_SUPPORTED = 801,

    /** @error Operation screen invalid */
    DISPLAY_MANAGER_ERROR_INVALID_SCREEN = 1400001,

    /** @error Operation invalid call */
    DISPLAY_MANAGER_ERROR_INVALID_CALL = 1400002,

    /** @error Operation system abnormal */
    DISPLAY_MANAGER_ERROR_SYSTEM_ABNORMAL = 1400003,
}

public enum NativeDisplayManager_Rotation
{
    /** device rotation 0 degree */
    DISPLAY_MANAGER_ROTATION_0,

    /** device rotation 90 degrees */
    DISPLAY_MANAGER_ROTATION_90,

    /** device rotation 180 degrees */
    DISPLAY_MANAGER_ROTATION_180,

    /** device rotation 270 degree */
    DISPLAY_MANAGER_ROTATION_270,
}

public enum NativeDisplayManager_Orientation
{
    /** device portrait show */
    DISPLAY_MANAGER_PORTRAIT = 0,

    /** device landscape show */
    DISPLAY_MANAGER_LANDSCAPE = 1,

    /** device portrait inverted show */
    DISPLAY_MANAGER_PORTRAIT_INVERTED = 2,

    /** device landscape inverted show */
    DISPLAY_MANAGER_LANDSCAPE_INVERTED = 3,

    /** device unknow show */
    DISPLAY_MANAGER_UNKNOWN,
}

public unsafe struct NativeDisplayManager_CutoutInfo
{
    /* boundingRects length */
    public int boundingRectsLength;

    /* boundingRects info pointer */
    public NativeDisplayManager_Rect* boundingRects;

    /* waterfallDisplayAreaRects info */
    public NativeDisplayManager_WaterfallDisplayAreaRects waterfallDisplayAreaRects;
}

public struct NativeDisplayManager_Rect
{
    /* rect left */
    public int left;
    /* rect top */
    public int top;
    /* rect width */
    public uint width;
    /* rect height */
    public uint height;
}

public struct NativeDisplayManager_WaterfallDisplayAreaRects
{
    /* waterfall left rect */
    public NativeDisplayManager_Rect left;

    /* waterfall top rect */
    public NativeDisplayManager_Rect top;

    /* waterfall right rect */
    public NativeDisplayManager_Rect right;

    /* waterfall bottom rect */
    public NativeDisplayManager_Rect bottom;
}

public enum NativeDisplayManager_FoldDisplayMode
{
    /** display mode unknown */
    DISPLAY_MANAGER_FOLD_DISPLAY_MODE_UNKNOWN = 0,

    /** display mode full */
    DISPLAY_MANAGER_FOLD_DISPLAY_MODE_FULL = 1,

    /** display mode main */
    DISPLAY_MANAGER_FOLD_DISPLAY_MODE_MAIN = 2,

    /** display mode sub */
    DISPLAY_MANAGER_FOLD_DISPLAY_MODE_SUB = 3,

    /** display mode coordination */
    DISPLAY_MANAGER_FOLD_DISPLAY_MODE_COORDINATION = 4,
}