using OpenHarmony.NDK.JSVMAPI;

namespace OpenHarmony.NDK.JSVMAPI
{
    /// <summary>
    /// 当一个.Net类、类属性、类方法将与ArkTS成员对应时，可以使用此特性进行标记。
    /// </summary>
    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Method |
                    AttributeTargets.Property |
                    AttributeTargets.Field)]
    public class ArkTSMemberAttribute : Attribute
    {
        public required short Since { get; init; } = 13;
        public short DeprecatedSince { get; init; } = 0;
        public required string Syscap { get; init; }
        public const short ModuleStaticMember = -1;
    }
}

// 下面规定ArkTS代码的转换规则，以模块@kit.CoreFileKit为例。

// 为每一个具有独立名称的模块创建一个命名空间。
// 命名规则如下所示。
namespace OpenHarmony.NDK.KitCoreFileKit
{
    // 当模块有静态成员时此处放置所有与相关的ArkTS静态成员，如果没有则不用创建此静态类。
    [ArkTSMember(Since = ArkTSMemberAttribute.ModuleStaticMember, Syscap = "")]
    public static class KitCoreFileKit
    {
        // @kit.CoreFileKit的静态成员数量为0，此处之作演示。
    }

    // 当ArkTS枚举的类型时string时规则如下，以@kit.CoreFileKit的PhotoViewMIMETypes为例。
    // 附：当ArkTS枚举的类型为number并具有Enum1 | Enum2的使用方式时，同样需要为转换来的枚举类型添加[Flag]特性

    [ArkTSMember(Since = 11, DeprecatedSince = 12, Syscap = "SystemCapability.FileManagement.UserFileService")]
    public static class PhotoViewMIMETypes
    {
        [ArkTSMember(Since = 11, Syscap = "SystemCapability.FileManagement.UserFileService")]
        public const string IMAGE_TYPE = "image/*";

        [ArkTSMember(Since = 11, Syscap = "SystemCapability.FileManagement.UserFileService")]
        public const string VIDEO_TYPE = "video/*";

        [ArkTSMember(Since = 11, Syscap = "SystemCapability.FileManagement.UserFileService")]
        public const string IMAGE_VIDEO_TYPE = "*/*";
    }

    // 类的转换生成无需多说。但需要注意以下几点：
    // 1. 属性和方法入参定义要保留可空注释。
    // 2. 返回Promise<T>的ArkTS方法在.net中也返回class Promise<T>，你先创建一个空类型，我调好C API生成的时候再处理。返回了Promise<T>的方法暂时标记不可用或弃用。
    // 3. ArkTS的基础类型在.Net中的命名是JS前缀+大写开头的原名。你同样先创建好空的class用着先即可。
    // 4. 你测试的时候先不使用.Net的分部能力，但要保留一个启用该能力的配置以在源生成器准备好后直接无缝衔接。目前方法有返回值的返回default即可，没有的就为空方法。
}