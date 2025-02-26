using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe static partial class display_manager
{
    [LibraryImport("libnative_display_manager.so")]
    public static partial NativeDisplayManager_ErrorCode OH_NativeDisplayManager_GetDefaultDisplayScaledDensity(float* Density);
}
