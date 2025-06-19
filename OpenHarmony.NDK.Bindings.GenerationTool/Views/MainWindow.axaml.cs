using System;
using System.Globalization;
using System.Reactive.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Markdig.Parsers;
using Markdig.Syntax;
using OpenHarmony.NDK.Bindings.GenerationTool.ViewModels;
using ReactiveUI;
using Ursa.Controls;
using Ursa.ReactiveUIExtension;
using Notification = Ursa.Controls.Notification;
using WindowNotificationManager = Ursa.Controls.WindowNotificationManager;

namespace OpenHarmony.NDK.Bindings.GenerationTool.Views;

public partial class MainWindow : ReactiveUrsaWindow<MainWindowViewModel>
{
    private WindowNotificationManager? _notificationManager;

    public MainWindow()
    {
        InitializeComponent();
        MessageBus.Current.Listen<Notification>().Do(DisplayGenerationProgressNotification).Subscribe();
        MessageBus.Current.Listen<Exception>().Do(ShowErrorInfo).Subscribe();
    }

    public static FuncValueConverter<BusyType, string?> BusyTypeToUITextFVC { get; } =
        new(busyType => busyType switch
        {
            BusyType.LoadingCapiRepository => GetResourceString("Text.LoadingCapiRepository"),
            BusyType.GeneratingCode => GetResourceString("Text.GeneratingCode"),
            BusyType.None => null,
            _ => throw new ArgumentOutOfRangeException(nameof(busyType), busyType, null)
        });

    public static FuncValueConverter<BusyType, bool> IsLoadingFVC { get; } =
        new(busyType => busyType is not BusyType.None);

    public static FuncValueConverter<double, double> GetTwoThirdsValueFVC { get; } = new(x => x / 3 * 2);

    public static FuncValueConverter<BusyType, double> GetOpenPaneLengthFVC { get; } =
        new(x => x is BusyType.None ? 0 : 38);

    public static FuncValueConverter<string?, MarkdownDocument> GetLogMdFVC { get; } = new(x =>
        MarkdownParser.Parse(
            $"""
             ```
             {x}
             ```
             """
            , Locales.MarkdownPipeline
        ));

    private void ShowErrorInfo(Exception obj)
    {
        MessageBox.ShowOverlayAsync($"{obj}",
            "生成时发生了无法处理的错误，请根据错误信息进行解决",
            icon: MessageBoxIcon.Error,
            button: MessageBoxButton.OK);
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        _notificationManager = new WindowNotificationManager(GetTopLevel(this))
        {
            Position = NotificationPosition.BottomRight,
            MaxItems = 5
        };
    }

    private void DisplayGenerationProgressNotification(Notification notification)
    {
        _notificationManager?.Show(notification);
    }

    private static string? GetResourceString(string key)
    {
        if (Application.Current?.TryGetResource(key, out var value) is true) return value as string;

        return null;
    }

    private void MenuItem_OnClick_ChangeLanguage(object? sender, RoutedEventArgs e)
    {
        if (sender is not MenuItem menuItem) return;
        var cultureInfo = new CultureInfo(menuItem.Tag!.ToString()!);
        var locales = ((App)Application.Current!).Locales;
        if (!Equals(locales.Current, cultureInfo))
            locales.Current = cultureInfo;
    }

    private void MenuItem_OnLoaded_ChangeLanguage(object? sender, RoutedEventArgs e)
    {
        if (sender is not MenuItem menuItem) return;
        var locales = ((App)Application.Current!).Locales;
        menuItem.IsChecked = Equals(locales.Current, new CultureInfo(menuItem.Tag!.ToString()!));
    }
}