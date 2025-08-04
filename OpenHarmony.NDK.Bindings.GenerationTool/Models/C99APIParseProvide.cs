using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DynamicData;

namespace OpenHarmony.NDK.Bindings.GenerationTool.Models;

public static class
    C99APIParseProvide
{
    public static IReadOnlyList<string> RootPathBlocklist { get; } =
    [
        "aarch64-linux-ohos",
        "x86_64-linux-ohos",
        "arm-linux-ohos",
        "asm-generic",
        "asm-loongarch",
        "asm-mips",
        "asm-riscv",
        "linux",
        "xen",
        "uv",
        "sys",
        "third_party"
    ];

    public static IReadOnlyList<string> RepoPathBlocklist { get; } =
    [
        "third_party"
    ];

    // [MustDisposeResource]
    // public static IEnumerator<Task?> StartParse(string projectDirPath, IEnumerable<StartParseInfo> startParseInfos)
    // {
    //     return startParseInfos.Select(startParseInfo => StartParse(projectDirPath, startParseInfo)).GetEnumerator();
    // }

    public static Process? StartParse(
        string sysrootDirPath,
        string llvmIncludeDirPath,
        StartParseInfo startParseInfo)
    {
        var sysrootIncludeDirPath = Path.Combine(sysrootDirPath, "usr", "include");
        List<string> arguments =
        [
            "--config", "preview-codegen",
            "--config", "exclude-fnptr-codegen",
            "--config", "generate-macro-bindings",
            "-F", $"{Path.Combine(sysrootDirPath, "usr", "include", startParseInfo.MethodClassName)}",
            "-a", $"--sysroot={sysrootDirPath}",
            "-a", "-nostdinc++",
            "-a", "--target aarch64-linux-musl",
            "-I", $"{sysrootIncludeDirPath}",
            "-I", $"{llvmIncludeDirPath}",
            "-I", $"{Path.Combine(sysrootIncludeDirPath, "aarch64-linux-ohos")}",
            "-o", $"{startParseInfo.OutputPath}",
            "-n", $"{startParseInfo.UseNamespace}",
            "-m", $"{startParseInfo.MethodClassName}"
        ];
        foreach (var item in startParseInfo.HeaderFilePath)
        {
            arguments.Add("-f");
            arguments.Add(item);
        }

        ProcessStartInfo processStartInfo = new("ClangSharpPInvokeGenerator", arguments)
            { CreateNoWindow = true, RedirectStandardOutput = true };
        return Process.Start(processStartInfo);
    }

    public static async Task GetAllHeaderFiles(string sysrootDirPath, string repoDirPath, IList<string> headerFilePaths)
    {
        if (Directory.Exists(repoDirPath) is false)
            throw new DirectoryNotFoundException($"Project directory '{repoDirPath}' does not exist.");

        var repoFiles = Task.Run(() => Directory.GetDirectories(repoDirPath)
            // 过滤无效的头文件目录获取路径
            .Where(PredicateHeaderFileDir)
            // 获得所有的头文件路径
            .SelectMany(CollectionSelector)
            .ToList());
        var sysrootIncludeDirPath = Path.Combine(sysrootDirPath, "usr", "include");
        var includeFiles = Task.Run(() => Directory.GetDirectories(sysrootIncludeDirPath)
            // 过滤无效的头文件目录获取路径
            .Where(PredicateHeaderFileDir)
            // 获得所有的头文件路径
            .SelectMany(CollectionSelector)
            .ToList());
        await Task.WhenAll(repoFiles, includeFiles);
        var result = await Task.Run(() =>
        {
            return includeFiles.Result.Where(x =>
                {
                    return repoFiles.Result.Find(y => Path.GetFileName(y) == Path.GetFileName(x)) is not null;
                })
                .ToList();
        });
        headerFilePaths.AddRange(result);
        return;

        static IEnumerable<string> CollectionSelector(string s)
        {
            return Directory.GetFiles(s, "*.h", SearchOption.AllDirectories);
        }

        static bool PredicateHeaderFileDir(string arg)
        {
            if (arg[^1] == Path.DirectorySeparatorChar) arg = arg.Remove(arg.Length - 1);
            return RootPathBlocklist.Contains(Path.GetFileName(arg)) is false;
        }
    }
}