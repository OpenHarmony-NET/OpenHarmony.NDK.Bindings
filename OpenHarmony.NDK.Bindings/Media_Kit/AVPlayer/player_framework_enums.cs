namespace OpenHarmony.NDK.Bindings.Media_Kit.AVPlayer
{
    public enum OH_AVErrCode
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        AV_ERR_OK,
        /// <summary>
        /// 无内存
        /// </summary>
        AV_ERR_NO_MEMORY,
        /// <summary>
        /// 操作不允许
        /// </summary>
        AV_ERR_OPERATE_NOT_PERMIT,
        /// <summary>
        /// 无效值
        /// </summary>
        AV_ERR_INVALID_VAL,
        /// <summary>
        /// IO错误
        /// </summary>
        AV_ERR_IO,
        /// <summary>
        /// 超时错误
        /// </summary>
        AV_ERR_TIMEOUT,
        /// <summary>
        /// 未知错误
        /// </summary>
        AV_ERR_UNKNOWN,
        /// <summary>
        /// 服务死亡
        /// </summary>
        AV_ERR_SERVICE_DIED,
        /// <summary>
        /// 当前状态不支持此操作
        /// </summary>
        AV_ERR_INVALID_STATE,
        /// <summary>
        /// 未支持的功能
        /// </summary>
        AV_ERR_UNSUPPORT,
        /// <summary>
        /// 扩展错误码初始值
        /// </summary>
        AV_ERR_EXTEND_START,
        /// <summary>
        /// DRM起始错误码。<br/>
        /// <b>起始版本： 12</b>
        /// </summary>
        AV_ERR_DRM_BASE,
        /// <summary>
        /// DRM解密失败。
        /// <b>起始版本： 12</b>
        /// </summary>
        AV_ERR_DRM_DECRYPT_FAILED,
        /// <summary>
        /// 视频起始错误码。<br/>
        /// <b>起始版本： 12</b>
        /// </summary>
        AV_ERR_VIDEO_BASE,
        /// <summary>
        /// 视频不支持色彩空间转换<br/>
        /// <b>起始版本： 12</b>
        /// </summary>
        AV_ERR_VIDEO_UNSUPPORTED_COLOR_SPACE_CONVERSION

    }
    /// <summary>
    /// 跳转模式
    /// </summary>
    public enum AVPlayerSeekMode
    {
        /// <summary>
        /// 同步到时间点之后的关键帧
        /// </summary>
        AV_SEEK_NEXT_SYNC,
        /// <summary>
        /// 同步到时间点之前的关键帧
        /// </summary>
        AV_SEEK_PREVIOUS_SYNC,
        /// <summary>
        /// 同步到距离指定时间点最近的帧<br/>
        /// <b>起始版本： 12</b>
        /// </summary>
        AV_SEEK_CLOSEST
    }
    public enum AVPlaybackSpeed
    {
        /// <summary>
        /// 0.75倍速播放
        /// </summary>
        AV_SPEED_FORWARD_0_75_X,
        /// <summary>
        ///  正常播放
        /// </summary>
        AV_SPEED_FORWARD_1_00_X,
        /// <summary>
        /// 1.25倍速播放
        /// </summary>
        AV_SPEED_FORWARD_1_25_X,
        /// <summary>
        /// 1.75倍速播放
        /// </summary>
        AV_SPEED_FORWARD_1_75_X,
        /// <summary>
        /// 2倍速播放
        /// </summary>
        AV_SPEED_FORWARD_2_00_X,
        /// <summary>
        /// 0.5倍速播放<br/>
        ///<b>起始版本： 12</b>
        /// </summary>
        AV_SPEED_FORWARD_0_50_X,
        /// <summary>
        /// 1.5倍速播放<br/>
        ///<b>起始版本： 12</b>
        /// </summary>
        AV_SPEED_FORWARD_1_50_X,
        /// <summary>
        /// 3.0倍速播放<br/>
        ///<b>起始版本： 13</b>
        /// </summary>
        AV_SPEED_FORWARD_3_00_X,
        /// <summary>
        /// 0.25倍速播放<br/>
        ///<b>起始版本： 13</b>
        /// </summary>
        AV_SPEED_FORWARD_0_25_X,
        /// <summary>
        /// 0.125倍速播放<br/>
        ///<b>起始版本： 13</b>
        /// </summary>
        AV_SPEED_FORWARD_0_125_X
    }
    public enum AVPlayerState
    {
        /// <summary>
        /// 空闲
        /// </summary>
        AV_IDLE,
        /// <summary>
        /// 初始化
        /// </summary>
        AV_INITIALIZED,
        /// <summary>
        /// 准备
        /// </summary>
        AV_PREPARED,
        /// <summary>
        /// 播放
        /// </summary>
        AV_PLAYING,
        /// <summary>
        /// 暂停
        /// </summary>
        AV_PAUSED,
        /// <summary>
        /// 停止
        /// </summary>
        AV_STOPPED,
        /// <summary>
        /// 结束
        /// </summary>
        AV_COMPLETED,
        /// <summary>
        /// 释放
        /// </summary>
        AV_RELEASED,
        /// <summary>
        /// 错误
        /// </summary>
        AV_ERROR
    }
    /// <summary>
    /// 信息类型<br/>
    /// 收到播放器消息时调用
    /// </summary>
    public enum AVPlayerOnInfoType
    {
        /// <summary>
        /// 跳转到对应播放位置时返回消息，extra表示seek到的位置
        /// </summary>
        AV_INFO_TYPE_SEEKDONE,
        /// <summary>
        /// 播放倍速设置完成时返回消息，extra表示播放倍速信息，具体请参考AVPlaybackSpeed
        /// </summary>
        AV_INFO_TYPE_SPEEDDONE,
        /// <summary>
        ///比特率设置完成时返回消息。<br/>
        ///key为OH_PLAYER_BITRATE：取值类型uint32_t。系统通过int32_t传递value，应用需先通过int32_t获取，再强制为uint32_t。
        /// </summary>
        AV_INFO_TYPE_BITRATEDONE,
        /// <summary>
        /// 播放完成时返回消息。
        /// </summary>
        AV_INFO_TYPE_EOS,
        /// <summary>
        /// 状态改变时返回消息。<br/>
        ///- key为OH_PLAYER_STATE：取值类型int32_t。系统通过int32_t传递value，应用需先通过int32_t获取，再强制转为AVPlayerState。<br/>
        ///- key为OH_PLAYER_STATE_CHANGE_REASON：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。1：用户操作触发；2：系统变更触发。
        /// </summary>
        AV_INFO_TYPE_STATE_CHANGE,
        /// <summary>
        /// 返回当前播放位置。<br/>
        ///key为OH_PLAYER_CURRENT_POSITION：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。
        /// </summary>
        AV_INFO_TYPE_POSITION_UPDATE,
        /// <summary>
        /// 视频开始渲染时返回消息。<br/>
        ///key为OH_PLAYER_MESSAGE_TYPE：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。1表示视频开始渲染。
        /// </summary>
        AV_INFO_TYPE_MESSAGE,
        /// <summary>
        /// 音量改变时返回消息。<br/>
        ///key为OH_PLAYER_VOLUME：取值类型float。系统通过float传递value，应用需通过float获取。取值范围[0.0, 1.0]。
        /// </summary>
        AV_INFO_TYPE_VOLUME_CHANGE,
        /// <summary>
        /// 首次获取视频大小或视频大小更新时返回消息。<br/>
        ///key为OH_PLAYER_VIDEO_WIDTH 或 OH_PLAYER_VIDEO_HEIGHT：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。
        /// </summary>
        AV_INFO_TYPE_RESOLUTION_CHANGE,
        /// <summary>
        /// 返回多队列缓冲时间。<br/>
        ///- key为OH_PLAYER_BUFFERING_TYPE：取值类型AVPlayerBufferingType。系统通过int32_t传递value，应用需先通过int32_t获取，再强制转为AVPlayerBufferingType。<br/>
        ///- key为OH_PLAYER_BUFFERING_VALUE：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。当缓冲更新消息类型是AVPLAYER_BUFFERING_PERCENT、AVPLAYER_BUFFERING_CACHED_DURATION时有效，分别表示缓冲进度完成百分比、缓冲数据可播放时长。
        /// </summary>
        AV_INFO_TYPE_BUFFERING_UPDATE,
        /// <summary>
        /// 上报HLS视频比特率列表消息。<br/>
        ///key为OH_PLAYER_BITRATE_ARRAY：取值类型uint8_t字节数组。应用需要先使用uint8_t类型指针变量保存比特率列表，使用size_t类型变量保存字节数组长度。然后分配若干个uint32_t类型的存储空间，接收将uint8_t字节数组转换为uint32_t类型比特率整数值。
        /// </summary>
        AV_INFO_TYPE_BITRATE_COLLECT,
        /// <summary>
        ///音频焦点改变时返回消息。<br/>
        ///取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。<br/>
        ///key为：<br/>
        ///- OH_PLAYER_AUDIO_INTERRUPT_TYPE：取值1表示中断事件开始；2表示结束。<br/>
        ///- OH_PLAYER_AUDIO_INTERRUPT_FORCE：取值0表示强制打断，系统改变音频播放状态；1表示共享打断，应用改变音频播放状态。<br/>
        ///- OH_PLAYER_AUDIO_INTERRUPT_HINT：取值0表示NONE，无提示；1表示RESUME，提示音频恢复；2表示PAUSE，提示音频暂停暂时失去焦点；3表示STOP，提示音频停止；4表示DUCK，音频降低音量；5表示UNDUCK，音频恢复音量。
        /// </summary>
        AV_INFO_TYPE_INTERRUPT_EVENT,
        /// <summary>
        /// 返回播放时长。<br/>
        ///key为OH_PLAYER_DURATION：取值类型int64_t。系统通过int64_t传递value，应用需通过int64_t获取。
        /// </summary>
        AV_INFO_TYPE_DURATION_UPDATE,
        /// <summary>
        /// 播放为直播流时返回消息。<br/>
        ///key为OH_PLAYER_IS_LIVE_STREAM：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。0表示非直播流，1表示直播流。
        /// </summary>
        AV_INFO_TYPE_IS_LIVE_STREAM,
        /// <summary>
        /// 轨道改变时返回消息，此场景暂未定义
        /// </summary>
        AV_INFO_TYPE_TRACKCHANGE,
        /// <summary>
        /// 轨道更新时返回消息，此场景暂未定义
        /// </summary>
        AV_INFO_TYPE_TRACK_INFO_UPDATE,
        /// <summary>
        /// 字幕信息更新时返回消息，此场景暂未定义
        /// </summary>
        AV_INFO_TYPE_SUBTITLE_UPDATE,
        /// <summary>
        ///音频输出设备改变时返回消息。<br/>
        ///key为OH_PLAYER_AUDIO_DEVICE_CHANGE_REASON：取值类型int32_t。系统通过int32_t传递value，应用需通过int32_t获取。
        /// </summary>
        AV_INFO_TYPE_AUDIO_OUTPUT_DEVICE_CHANGE
    }
    /// <summary>
    /// 音频流设置的类型
    /// </summary>
    public enum OH_AudioStream_Usage
    {
        /// <summary>
        /// 未知类型
        /// </summary>
        AUDIOSTREAM_USAGE_UNKNOWN,
        /// <summary>
        /// 音乐
        /// </summary>
        AUDIOSTREAM_USAGE_MUSIC,
        /// <summary>
        /// VoIP语音通话
        /// </summary>
        AUDIOSTREAM_USAGE_VOICE_COMMUNICATION,
        /// <summary>
        /// 语音播报
        /// </summary>
        AUDIOSTREAM_USAGE_VOICE_ASSISTANT,
        /// <summary>
        /// 闹钟
        /// </summary>
        AUDIOSTREAM_USAGE_ALARM,
        /// <summary>
        /// 语音消息
        /// </summary>
        AUDIOSTREAM_USAGE_VOICE_MESSAGE,
        /// <summary>
        /// 铃声
        /// </summary>
        AUDIOSTREAM_USAGE_RINGTONE,
        /// <summary>
        /// 通知
        /// </summary>
        AUDIOSTREAM_USAGE_NOTIFICATION,
        /// <summary>
        /// 无障碍
        /// </summary>
        AUDIOSTREAM_USAGE_ACCESSIBILITY,
        /// <summary>
        /// 电影或视频
        /// </summary>
        AUDIOSTREAM_USAGE_MOVIE,
        /// <summary>
        /// 游戏
        /// </summary>
        AUDIOSTREAM_USAGE_GAME,
        /// <summary>
        /// 有声读物（包括听书、相声、评书）、听新闻、播客等
        /// </summary>
        AUDIOSTREAM_USAGE_AUDIOBOOK,
        /// <summary>
        /// 导航
        /// </summary>
        AUDIOSTREAM_USAGE_NAVIGATION,
        /// <summary>
        /// VoIP视频通话<br/>
        /// <b>起始版本： 12</b>
        /// </summary>
        AUDIOSTREAM_USAGE_VIDEO_COMMUNICATION
    }
    /// <summary>
    /// 音效模式<br/>
    /// <b>起始版本： 12</b>
    /// </summary>
    public enum OH_AudioStream_AudioEffectMode
    {
        /// <summary>
        /// 无音效模式
        /// </summary>
        EFFECT_NONE,
        /// <summary>
        /// 默认音效模式
        /// </summary>
        EFFECT_DEFAULT
    }
}
