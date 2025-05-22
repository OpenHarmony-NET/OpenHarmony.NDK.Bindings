using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace OpenHarmony.NDK.Bindings.Media_Kit.AVPlayer
{
    /// <summary>
    /// AVPlayer<br/>
    /// <see cref="https://developer.huawei.com/consumer/cn/doc/harmonyos-references/avplayer_8h"/>
    /// </summary>
    public unsafe partial struct OH_AVPlayer
    {

        [LibraryImport("libavplayer.so")]
        public static partial OH_AVPlayer* OH_AVPlayer_Create();

        /// <summary>
        /// 设置播放器的播放源。对应的源可以是http url。
        /// </summary>
        /// <param name="player"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetURLSource(OH_AVPlayer* player, [MarshalAs(UnmanagedType.LPStr)] string url);
        /// <summary>
        /// 设置播放器的播放媒体文件描述符来源
        /// </summary>
        /// <param name="player"></param>
        /// <param name="fd"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetFDSource(OH_AVPlayer* player, int fd, long offset, long size);
        /// <summary>
        /// 准备播放环境，异步缓存媒体数据
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Prepare(OH_AVPlayer* player);
        /// <summary>
        /// 开始播放
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Play(OH_AVPlayer* player);
        /// <summary>
        /// 暂停播放
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Pause(OH_AVPlayer* player);
        /// <summary>
        /// 停止播放
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Stop(OH_AVPlayer* player);
        /// <summary>
        /// 将播放器恢复到初始状态
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Reset(OH_AVPlayer* player);
        /// <summary>
        /// 异步释放播放器资源
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>

        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Release(OH_AVPlayer* player);
        /// <summary>
        /// 同步释放播放器资源
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_ReleaseSync(OH_AVPlayer* player);
        /// <summary>
        /// 设置播放器的音量
        /// </summary>
        /// <param name="player"></param>
        /// <param name="leftVolume"></param>
        /// <param name="rightVolume"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetVolume(OH_AVPlayer* player, float leftVolume, float rightVolume);
        /// <summary>
        /// 改变播放位置
        /// </summary>
        /// <param name="player"></param>
        /// <param name="mSeconds"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_Seek(OH_AVPlayer* player, int mSeconds, AVPlayerSeekMode mode);
        /// <summary>
        /// 获取播放位置，精确到毫秒。
        /// </summary>
        /// <param name="player"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetCurrentTime(OH_AVPlayer* player, int* currentTime);
        /// <summary>
        /// 获取视频高度
        /// </summary>
        /// <param name="player"></param>
        /// <param name="videoHeight"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetVideoHeight(OH_AVPlayer* player, int* videoHeight);
        /// <summary>
        /// 设置播放器播放速率
        /// </summary>
        /// <param name="player"></param>
        /// <param name="speed"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetPlaybackSpeed(OH_AVPlayer* player, AVPlaybackSpeed speed);
        /// <summary>
        /// 设置player音频流类型
        /// </summary>
        /// <param name="player"></param>
        /// <param name="speed"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetPlaybackSpeed(OH_AVPlayer* player, AVPlaybackSpeed* speed);
        /// <summary>
        /// 设置player音频流类型
        /// </summary>
        /// <param name="player"></param>
        /// <param name="streamUsage"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetAudioRendererInfo(OH_AVPlayer* player, OH_AudioStream_Usage streamUsage);
        /// <summary>
        /// 设置player音频流的音效模式
        /// </summary>
        /// <param name="player"></param>
        /// <param name="effectMode"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetAudioEffectMode(OH_AVPlayer* player, OH_AudioStream_AudioEffectMode effectMode);
        /// <summary>
        /// 设置hls播放器使用的码率
        /// </summary>
        /// <param name="player"></param>
        /// <param name="bitRate"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SelectBitRate(OH_AVPlayer* player, int bitRate);
        /// <summary>
        /// 设置播放画面窗口
        /// </summary>
        /// <param name="player"></param>
        /// <param name="window"></param>
        /// <returns></returns>

        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetVideoSurface(OH_AVPlayer* player, OHNativeWindow* window);
        /// <summary>
        /// 获取媒体文件的总时长，精确到毫秒
        /// </summary>
        /// <param name="player"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetDuration(OH_AVPlayer* player, int* duration);
        /// <summary>
        /// 获取当前播放状态
        /// </summary>
        /// <param name="player"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetState(OH_AVPlayer* player, AVPlayerState* state);
        /// <summary>
        /// 判断播放器是否在播放
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_Bool OH_AVPlayer_IsPlaying(OH_AVPlayer* player);
        /// <summary>
        /// 判断是用循环播放
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>

        [LibraryImport("libavplayer.so")]
        public static partial OH_Bool OH_AVPlayer_IsLooping(OH_AVPlayer* player);
        /// <summary>
        /// 设置循环播放
        /// </summary>
        /// <param name="player"></param>
        /// <param name="loop"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetLooping(OH_AVPlayer* player, OH_Bool loop);

        /// <summary>
        /// 设置播放器回调方法<br/>
        /// 由于通过此方法设置的信息监听回调函数OH_AVPlayerOnInfo和错误监听回调函数OH_AVPlayerOnError可以传递信息有限，也不便于应用区分多个播放器实例。<br/>
        /// <b>从 API 12 开始</b>，应使用OH_AVPlayer_SetOnInfoCallback()、OH_AVPlayer_SetOnErrorCallback()接口分别设置信息监听回调函数OH_AVPlayerOnInfoCallback和错误监听回调函数OH_AVPlayerOnErrorCallback。
        /// </summary>
        /// <param name="player"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        [Obsolete]
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetPlayerCallback(OH_AVPlayer* player, AVPlayerCallback callback);
        /// <summary>
        /// 选择音频或字幕轨道
        /// </summary>
        /// <param name="player"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SelectTrack(OH_AVPlayer* player, int index);
        /// <summary>
        /// 取消选择当前音频或字幕轨道
        /// </summary>
        /// <param name="player"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_DeselectTrack(OH_AVPlayer* player, int index);
        /// <summary>
        /// 获取当前有效的轨道索引
        /// </summary>
        /// <param name="player"></param>
        /// <param name="trackType"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetCurrentTrack(OH_AVPlayer* player, int trackType, int* index);
        /// <summary>
        /// 设置播放器媒体密钥系统信息回调的方法
        /// </summary>
        /// <param name="player"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetMediaKeySystemInfoCallback(OH_AVPlayer* player, delegate* unmanaged[Cdecl]<OH_AVPlayer* , DRM_MediaKeySystemInfo* > callback);
        /// <summary>
        /// 获取媒体密钥系统信息以创建媒体密钥会话
        /// </summary>
        /// <param name="player"></param>
        /// <param name="mediaKeySystemInfo"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_GetMediaKeySystemInfo(OH_AVPlayer* player, DRM_MediaKeySystemInfo* mediaKeySystemInfo);
        /// <summary>
        /// 设置解密信息
        /// </summary>
        /// <param name="player"></param>
        /// <param name="mediaKeySession"></param>
        /// <param name="secureVideoPath"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetDecryptionConfig(OH_AVPlayer* player, MediaKeySession* mediaKeySession, OH_Bool secureVideoPath);

        /// <summary>
        /// 设置播放器消息回调监听函数
        /// </summary>
        /// <param name="player"></param>
        /// <param name="callback"></param>
        /// <param name="userData"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetOnInfoCallback(OH_AVPlayer* player,
            delegate* unmanaged[Cdecl]<OH_AVPlayer*, AVPlayerOnInfoType, OH_AVFormat*, void*, void> callback,
            IntPtr userData);

        /// <summary>
        /// 设置播放器错误回调监听函数
        /// </summary>
        /// <param name="player"></param>
        /// <param name="callback"></param>
        /// <param name="userData"></param>
        /// <returns></returns>
        [LibraryImport("libavplayer.so")]
        public static partial OH_AVErrCode OH_AVPlayer_SetOnErrorCallback(OH_AVPlayer* player,
            delegate* unmanaged[Cdecl]<OH_AVPlayer*, int, nint, void*, void> callback, IntPtr userData);
    }
}
