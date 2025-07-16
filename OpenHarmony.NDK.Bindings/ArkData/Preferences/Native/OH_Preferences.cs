using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings;

/// <summary>
/// 定义Preferences对象类型。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct OH_Preferences;

/// <summary>
/// Preferences数据变更观察者回调函数类型。
/// </summary>
/// <param name="context">用户上下文数据</param>
/// <param name="pairs">变更的键值对数组</param>
/// <param name="count">变更的键值对数量</param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void OH_PreferencesDataObserver(void* context, OH_PreferencesPair* pairs, uint count);
