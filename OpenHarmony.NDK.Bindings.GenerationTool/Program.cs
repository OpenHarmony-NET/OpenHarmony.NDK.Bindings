using CppSharp;
using CppSharp.Parser;
using OpenHarmony.NDK.Bindings.GenerationTool;

var headerFileDirPath = args.FirstOrDefault();

headerFileDirPath = @"D:\Project\OpenHarmony\interface_sdk_c";

if (Directory.Exists(headerFileDirPath) is false)
{
    Console.WriteLine("未传入有效的头文件目录路径，请输入有效的路径：");
    headerFileDirPath = Console.ReadLine();
    if (Directory.Exists(headerFileDirPath) is false)
    {
        Console.WriteLine("无效路径，工具将在3秒后推出。");
        return -1;
    }
}

ConsoleDriver.Run(new ParesOptions(headerFileDirPath));

return 0;