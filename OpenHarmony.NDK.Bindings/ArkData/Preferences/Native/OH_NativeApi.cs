using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings
{
    /// <summary>
    /// 提供 OpenHarmony NativeApi 的 P/Invoke 方法封装
    /// </summary>
    public static unsafe partial class OH_NativeApi
    {
        #region OH_Preferences

        /// <summary>
        /// 打开一个Preferences实例对象并创建指向它的指针。当不再需要使用指针时，请使用OH_Preferences_Close关闭实例对象。
        /// </summary>
        /// <param name="option"></param>
        /// <param name="errCode"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial OH_Preferences* OH_Preferences_Open(OH_PreferencesOption* option, int* errCode);

        /// <summary>
        /// 关闭一个Preferences实例对象。
        /// </summary>
        /// <param name="preference"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_Close(OH_Preferences* preference);
        /// <summary>
        /// 获取Preferences实例对象中Key对应的整型值。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_GetInt(OH_Preferences* preference, char* key, int* value);

        /// <summary>
        /// 获取Preferences实例对象中Key对应的布尔值。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_GetBool(OH_Preferences* preference, char* key, bool* value);

        /// <summary>
        /// 获取Preferences实例对象中Key对应的字符串。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so", StringMarshalling = StringMarshalling.Utf8)]
        public static partial int OH_Preferences_GetString(OH_Preferences* preference, string key, char** value, uint* valueLen);

        /// <summary>
        /// 释放从Preferences实例对象中获取的字符串。
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        [LibraryImport("libohpreferences.so")]
        public static partial void OH_Preferences_FreeString(char* @string);

        /// <summary>
        /// 根据Key设置Preferences实例对象中的整型值。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_SetInt(OH_Preferences* preference, char* key, int value);

        /// <summary>
        /// 根据Key设置Preferences实例对象中的布尔值。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_SetBool(OH_Preferences* preference, char* key, [MarshalAs(UnmanagedType.Bool)] bool value);

        /// <summary>
        /// 根据Key设置Preferences实例对象中的字符串。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_SetString(OH_Preferences* preference, char* key, char* value);

        /// <summary>
        /// 在Preferences实例对象中删除Key对应的KV数据。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_Delete(OH_Preferences* preference, char* key);

        /// <summary>
        /// 对选取的Key注册数据变更订阅。订阅的Key的值发生变更后，在调用OH_Preferences_Close()后触发回调。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name="context"></param>
        /// <param name="observer"></param>
        /// <param name="keys"></param>
        /// <param name="keyCount"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_RegisterDataObserver(OH_Preferences* preference, void* context, IntPtr observer, char*[] keys, uint keyCount);

        /// <summary>
        /// 取消注册选取Key的数据变更订阅。
        /// </summary>
        /// <param name="preference"></param>
        /// <param name="context"></param>
        /// <param name="observer"></param>
        /// <param name="keys"></param>
        /// <param name="keyCount"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_UnregisterDataObserver(OH_Preferences* preference, void* context, IntPtr observer, char*[] keys, uint keyCount);

        /// <summary>
        /// 校验当前平台是否支持对应存储模式。
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isSupported"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_Preferences_IsStorageTypeSupported(PreferencesStorageType type, bool* isSupported);
        #endregion

        #region OH_PreferencesOption

        /// <summary>
        /// 创建一个Preferences配置选项的OH_PreferencesOption实例对象以及指向它的指针。当不再需要使用指针时，请使用OH_PreferencesOption_Destroy销毁实例对象，否则会导致内存泄漏。
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial OH_PreferencesOption* OH_PreferencesOption_Create();

        /// <summary>
        /// 设置Preferences配置选项OH_PreferencesOption实例对象的文件名称。
        /// </summary>
        /// <param name="option"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesOption_SetFileName(OH_PreferencesOption* option, char* fileName);

        /// <summary>
        /// 设置Preferences配置选项OH_PreferencesOption实例对象的包名称。
        /// </summary>
        /// <param name="option"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesOption_SetBundleName(OH_PreferencesOption* option, char* bundleName);

        /// <summary>
        /// 设置Preferences配置选项OH_PreferencesOption实例对象的应用组ID。设置应用组ID后，会指定在此应用组ID对应的沙箱路径下创建Preferences实例。应用组ID需要向应用市场获取，暂不支持。当传入的应用组ID为空字符串时，默认在本应用沙箱目录下创建Preferences实例。
        /// </summary>
        /// <param name="option"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesOption_SetDataGroupId(OH_PreferencesOption* option, char* dataGroupId);

        /// <summary>
        /// 设置Preferences实例对象的存储模式。
        /// </summary>
        /// <param name="option"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesOption_SetStorageType(OH_PreferencesOption* option, PreferencesStorageType type);

        /// <summary>
        /// 销毁Preferences配置选项OH_PreferencesOption实例。
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesOption_Destroy(OH_PreferencesOption* option);

        #endregion

        #region OH_PreferencesPair

        /// <summary>
        /// 获取KV数据中索引对应数据的键。
        /// </summary>
        [LibraryImport("libohpreferences.so")]
        public static partial char* OH_PreferencesPair_GetKey(OH_PreferencesPair* pairs, uint index);

        /// <summary>
        /// 获取KV数据数组中索引对应的值。
        /// </summary>
        [LibraryImport("libohpreferences.so")]
        public static partial OH_PreferencesValue* OH_PreferencesPair_GetPreferencesValue(OH_PreferencesPair* pairs, uint index);

        #endregion

        #region OH_PreferencesValue

        /// <summary>
        /// 获取PreferencesValue对象的数据类型。
        /// </summary>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial PreferenceValueType OH_PreferencesValue_GetValueType(OH_PreferencesValue* @object);

        /// <summary>
        /// 从PreferencesValue对象OH_PreferencesValue中获取一个整型值。
        /// </summary>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesValue_GetInt(OH_PreferencesValue* @object, int* value);

        /// <summary>
        /// 从PreferencesValue对象OH_PreferencesValue中获取一个布尔值。
        /// </summary>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesValue_GetBool(OH_PreferencesValue* @object, bool* value);

        /// <summary>
        /// 从PreferencesValue对象OH_PreferencesValue中获取字符串。
        /// </summary>
        /// <returns></returns>
        [LibraryImport("libohpreferences.so")]
        public static partial int OH_PreferencesValue_GetString(OH_PreferencesValue* @object, char** value, uint* valueLen);

        #endregion
    }
}
