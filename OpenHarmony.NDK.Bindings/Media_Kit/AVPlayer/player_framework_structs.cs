using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.NDK.Bindings.Media_Kit.AVPlayer
{
    public unsafe delegate void OH_AVPlayerOnInfo(OH_AVPlayer* player, AVPlayerOnInfoType type, int extra);
    /// <summary>
    ///errorCode :<br/>
    ///AV_ERR_NO_MEMORY：无内存，取值为1<br/>
    ///AV_ERR_OPERATE_NOT_PERMIT：操作不允许，取值为2<br/>
    ///AV_ERR_INVALID_VAL：无效值，取值为3<br/>
    ///AV_ERR_IO：IO错误，取值为4<br/>
    ///AV_ERR_TIMEOUT：超时错误，取值为5<br/>
    ///AV_ERR_UNKNOWN：未知错误，取值为6<br/>
    ///AV_ERR_SERVICE_DIED：服务死亡，取值为7<br/>
    ///AV_ERR_INVALID_STATE：当前状态不支持此操作，取值为8<br/>
    ///AV_ERR_UNSUPPORT：未支持的接口，取值为9<br/>
    ///AV_ERR_EXTEND_START：扩展错误码初始值，取值为100<br/>
    /// </summary>
    /// <param name="player"></param>
    /// <param name="errorCode"></param>
    /// <param name="errorMsg"></param>
    public unsafe delegate void OH_AVPlayerOnError(OH_AVPlayer* player, int errorCode, nint errorMsg);
    public unsafe delegate void Player_MediaKeySystemInfoCallback(OH_AVPlayer* player, DRM_MediaKeySystemInfo* mediaKeySystemInfo);
    /// <summary>
    /// 收到播放器消息时被调用。如果应用成功设置该回调，则不会回调OH_AVPlayerOnInfo函数
    /// </summary>
    /// <param name="player"></param>
    /// <param name="type"></param>
    /// <param name="infoBody"></param>
    /// <param name="userData"></param>
    public unsafe delegate void OH_AVPlayerOnInfoCallback(OH_AVPlayer* player, AVPlayerOnInfoType type, OH_AVFormat* infoBody, void* userData);
    /// <summary>
    /// 发生错误时被调用。如果应用成功设置该回调，则不会回调OH_AVPlayerOnError函数。<br/>
    ///errorCode :<br/>
    ///AV_ERR_NO_MEMORY：无内存，取值为1<br/>
    ///AV_ERR_OPERATE_NOT_PERMIT：操作不允许，取值为2<br/>
    ///AV_ERR_INVALID_VAL：无效值，取值为3<br/>
    ///AV_ERR_IO：IO错误，取值为4<br/>
    ///AV_ERR_TIMEOUT：超时错误，取值为5<br/>
    ///AV_ERR_UNKNOWN：未知错误，取值为6<br/>
    ///AV_ERR_SERVICE_DIED：服务死亡，取值为7<br/>
    ///AV_ERR_INVALID_STATE：当前状态不支持此操作，取值为8<br/>
    ///AV_ERR_UNSUPPORT：未支持的接口，取值为9<br/>
    /// </summary>
    /// <param name="player"></param>
    /// <param name="errorCode"></param>
    /// <param name="errorMsg"></param>
    /// <param name="userData"></param>
    public unsafe delegate void OH_AVPlayerOnErrorCallback(OH_AVPlayer* player, int errorCode, nint errorMsg, void* userData);

    public struct MediaKeySession
    {

    }
    public struct OH_AVFormat
    {

    }
    public struct DRM_MediaKeySystemInfo
    {
        public int PsshCount { get; set; }
        public DRM_PsshInfo PsshInfo { get; set; }
    }
    /// <summary>
    /// uuid的PSSH信息<br/>
    /// https://developer.huawei.com/consumer/cn/doc/harmonyos-references/_d_r_m___pssh_info
    /// </summary>
    public struct DRM_PsshInfo
    {
        public uint UuId { get; set; }
        public int DataLen { get; set; }
        public uint Data { get; set; }
    }
    public struct OHNativeWindow
    {

    }

    public struct AVPlayerCallback
    {
        /// <summary>
        /// Info 委托方法<br/>
        /// 使用 OpenHarmony.NDK.Bindings.AVPlayer.OH_AVPlayerOnInfo 委托实现指针传递
        /// </summary>
        public nint OH_AVPlayerOnInfo { get; set; }
        /// <summary>
        /// Error 委托方法<br/>
        /// 使用 OpenHarmony.NDK.Bindings.AVPlayer.OH_AVPlayerOnError 委托实现指针传递
        /// </summary>
        public nint OH_AVPlayerOnError { get; set; }
    }
}
