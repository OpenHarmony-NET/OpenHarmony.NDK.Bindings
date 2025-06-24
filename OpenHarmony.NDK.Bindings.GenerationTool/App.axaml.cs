using Akavache;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Irihi.Mantra.Markdown;
using Irihi.Mantra.Markdown.BlockGenerators;
using Irihi.Mantra.Markdown.Plugin.AvaloniaHybrid;
using OpenHarmony.NDK.Bindings.GenerationTool.ViewModels;
using OpenHarmony.NDK.Bindings.GenerationTool.Views;

namespace OpenHarmony.NDK.Bindings.GenerationTool;

public class App : Application
{
    public Locales Locales { get; } = new();

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        Styles.Add(Locales);
        MarkdownBlockGenerators.Default.Plugins.Add(new FencedCodeBlockGenerator());
        MarkdownBlockGenerators.Default.Plugins.Add(new AvaloniaHybridBlockGenerator());

        Registrations.Start("OpenHarmony.NDK.Bindings.GenerationTool");
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };
            desktop.Exit += (_, _) =>
            {
                // Ensure that the application exits cleanly
                BlobCache.Shutdown().Wait();
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}