using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;

namespace OpenHarmony.NDK.Bindings.GenerationTool;

public class ParesOptions : ILibrary
{
    public ParesOptions(string headerFileDirPath)
    {
        HeaderFileDirPath = headerFileDirPath;
    }

    public string HeaderFileDirPath { get; }

    public void Preprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Postprocess(Driver driver, ASTContext ctx)
    {
    }

    public void Setup(Driver driver)
    {
        // driver.ParserOptions.TargetTriple = "x86_64-linux-gnu";
        var options = driver.Options;
        options.OutputDir = "../../../../OpenHarmony.NDK.Bindings";
        options.GeneratorKind = GeneratorKind.CSharp;
        var module = options.AddModule("libjsvm");
        var pathBuf = Path.Combine(HeaderFileDirPath, @"ark_runtime\jsvm");
        module.IncludeDirs.Add(pathBuf);
        module.Headers.Add(Path.Combine(pathBuf, "jsvm.h"));
        module.Headers.Add(Path.Combine(pathBuf, "jsvm_types.h"));
        module.OutputNamespace = "OpenHarmony.NDK.Bindings";
    }

    public void SetupPasses(Driver driver)
    {
        driver.Context.TranslationUnitPasses.RenameDeclsUpperCase(RenameTargets.Any);
        driver.Context.TranslationUnitPasses.AddPass(new FunctionToInstanceMethodPass());
    }
}