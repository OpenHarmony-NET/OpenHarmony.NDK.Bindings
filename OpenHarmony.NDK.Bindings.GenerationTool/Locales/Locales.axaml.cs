using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using Avalonia.Styling;
using Irihi.Mantra.Markdown.Plugin.AvaloniaHybrid.MarkdigPlugins;
using Markdig;
using Markdig.Parsers;

namespace OpenHarmony.NDK.Bindings.GenerationTool;

public class Locales : Styles, IResourceNode
{
    public static readonly StyledProperty<CultureInfo> CurrentProperty =
        AvaloniaProperty.Register<Locales, CultureInfo>(
            nameof(Current));

    private readonly ResourceDictionary _default;
    private readonly Dictionary<CultureInfo, ResourceDictionary> _dictionary = new();

    public Locales(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(this);
        _default = GetAndRemove("zh-CN");
        _dictionary.Add(new CultureInfo("zh-CN"), _default);
        _dictionary.Add(new CultureInfo("en-US"), GetAndRemove("en-US"));
        Current = CultureInfo.CurrentCulture;


        return;

        ResourceDictionary GetAndRemove(string key)
        {
            var resource = Resources[key] as ResourceDictionary
                           ?? throw new KeyNotFoundException($"Key {key} was not found in the resources");
            Resources.Remove(key);
            string[] mdList =
            [
                // "MDText.GenerationDialog.md",
                "MDText.HomeView.md"
            ];
            foreach (var name in mdList)
            {
                var uri = new Uri($"avares://OpenHarmony.NDK.Bindings.GenerationTool/Locales/{key}/{name}",
                    UriKind.Absolute);
                try
                {
                    using var streamReader = new StreamReader(AssetLoader.Open(uri));
                    var result = streamReader.ReadToEnd();
                    resource.TryAdd(name, MarkdownParser.Parse(result, MarkdownPipeline));
                }
                catch (Exception)
                {
                    Console.Error.WriteLine("Failed to load resource: " + uri);
                }
            }

            return resource;
        }
    }

    public static MarkdownPipeline MarkdownPipeline { get; } = new MarkdownPipelineBuilder()
        .UseAvaloniaHybrid()
        .UseAlertBlocks()
        .UseAutoIdentifiers()
        .UseAbbreviations()
        .UsePreciseSourceLocation()
        .UseBootstrap()
        .UseAutoLinks()
        .UseCitations()
        .UseDiagrams()
        .UseGridTables()
        .UsePipeTables()
        .UseFigures()
        .UseFooters()
        .UseGlobalization()
        .UseAdvancedExtensions()
        .UseFootnotes()
        .UseEmphasisExtras()
        .UseGenericAttributes()
        .UseListExtras()
        .Build();

    public CultureInfo Current
    {
        get => GetValue(CurrentProperty);
        set => SetValue(CurrentProperty, value);
    }

    bool IResourceNode.TryGetResource(object key, ThemeVariant? theme, out object? value)
    {
        return _dictionary.GetValueOrDefault(Current, _default).TryGetValue(key, out value) ||
               base.TryGetResource(key, theme, out value);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);

        if (change.Property == CurrentProperty) Owner?.NotifyHostedResourcesChanged(ResourcesChangedEventArgs.Empty);
    }
}