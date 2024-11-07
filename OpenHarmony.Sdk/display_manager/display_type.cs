using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Sdk;

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