using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using Avalonia.Controls.Notifications;
using DynamicData;
using OpenHarmony.NDK.Bindings.GenerationTool.Models;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using ReactiveUI.Validation.Extensions;
using Notification = Ursa.Controls.Notification;

namespace OpenHarmony.NDK.Bindings.GenerationTool.ViewModels;

public partial class MainWindowViewModel : ViewModelBase, IValidatableViewModel
{
    private readonly IObservable<bool> _can_StartFullGeneration;
    private readonly SourceList<Notification> _generationLogList = new();
    [BindableDerivedList] private readonly ReadOnlyObservableCollection<Notification> _view_GenerationLogList;
    private sbyte _loderIndex;

    public MainWindowViewModel()
    {
        ValidationContext = new ValidationContext();
        this.WhenAnyValue(x => x.NDK_CAPI_RepoDirPath)
            .Do(x => SaveLastUsePath(nameof(NDK_CAPI_RepoDirPath), x))
            .Subscribe();
        this.WhenAnyValue(x => x.NDK_CAPI_SysRootDirPath)
            .Do(x => SaveLastUsePath(nameof(NDK_CAPI_SysRootDirPath), x))
            .Subscribe();
        this.WhenAnyValue(x => x.OutputDirectoryPath)
            .Do(x => SaveLastUsePath(nameof(OutputDirectoryPath), x))
            .Subscribe();
        this.WhenAnyValue(x => x.NDK_CAPI_LlvmIncludeDirPath)
            .Do(x => SaveLastUsePath(nameof(NDK_CAPI_LlvmIncludeDirPath), x))
            .Subscribe();
        this.ValidationRule(x => x.NDK_CAPI_RepoDirPath,
            x => Directory.Exists(x),
            "Path does not exist.");
        this.ValidationRule(x => x.NDK_CAPI_SysRootDirPath,
            x => Directory.Exists(x),
            "Path does not exist.");
        this.ValidationRule(x => x.OutputDirectoryPath,
            x => Directory.Exists(x),
            "Path does not exist.");
        this.ValidationRule(x => x.NDK_CAPI_LlvmIncludeDirPath,
            x => Directory.Exists(x),
            "Path does not exist.");

        BlobCache.UserAccount.GetOrFetchObject(nameof(NDK_CAPI_RepoDirPath), () => Task.FromResult(""))
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(x =>
            {
                NDK_CAPI_RepoDirPath = x;
                _loderIndex++;
            });
        BlobCache.UserAccount.GetOrFetchObject(nameof(NDK_CAPI_SysRootDirPath), () => Task.FromResult(""))
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(x =>
            {
                NDK_CAPI_SysRootDirPath = x;
                _loderIndex++;
            });
        BlobCache.UserAccount.GetOrFetchObject(nameof(OutputDirectoryPath), () => Task.FromResult(""))
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(x =>
            {
                OutputDirectoryPath = x;
                _loderIndex++;
            });
        BlobCache.UserAccount.GetOrFetchObject(nameof(NDK_CAPI_LlvmIncludeDirPath), () => Task.FromResult(""))
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(x =>
            {
                NDK_CAPI_LlvmIncludeDirPath = x;
                _loderIndex++;
            });
        _generationLogList
            .Connect()
            .Bind(out _view_GenerationLogList)
            .Subscribe();
        _can_StartFullGeneration = this.WhenAnyObservable(x => x.ValidationContext.Valid);
        GenerationProgressEndValue = 1;
        GenerationProgress = 0;
    }

    [Reactive] public partial string? NDK_CAPI_SysRootDirPath { get; set; }
    [Reactive] public partial string? NDK_CAPI_RepoDirPath { get; set; }
    [Reactive] public partial string? NDK_CAPI_LlvmIncludeDirPath { get; set; }
    [Reactive] public partial string? OutputDirectoryPath { get; set; }
    [Reactive] public partial BusyType LoadingMessage { get; private set; }
    [Reactive] public partial double GenerationProgress { get; private set; }
    [Reactive] public partial double GenerationProgressEndValue { get; private set; }

    public IValidationContext ValidationContext { get; }

    private void SaveLastUsePath(string key, string? path)
    {
        if (_loderIndex != 4) return;
        BlobCache.UserAccount.InsertObject(key, path);
        BlobCache.UserAccount.Flush();
    }

    [ReactiveCommand(CanExecute = nameof(_can_StartFullGeneration))]
    private async Task StartFullGeneration()
    {
        try
        {
            LoadingMessage = BusyType.LoadingCapiRepository;
            List<string> headerFilePaths = new();
            await C99APIParseProvide.GetAllHeaderFiles(NDK_CAPI_SysRootDirPath!, NDK_CAPI_RepoDirPath!,
                headerFilePaths);
            // 处理一些因为不符合NDK CAPI规范的头文件导致的模块绑定创建失败
            // network模块的
            headerFilePaths.Remove(headerFilePaths.Find(x => Path.GetFileName(x) == "net_websocket_type.h") ?? "");
            // window_manager模块的
            var fix = headerFilePaths.Find(x => Path.GetFileName(x) == "oh_window.h");
            if (File.Exists(fix))
            {
                headerFilePaths.Remove(fix);
                fix = $"{fix}.fix.h";
                headerFilePaths.Add(fix);
            }

            var sysrootIncludeDirPath = Path.Combine(NDK_CAPI_SysRootDirPath!, "usr", "include");
            var dirs = Directory.GetDirectories(sysrootIncludeDirPath!).ToList();
            var includes = headerFilePaths.GroupBy(x => dirs.Find(x.StartsWith)).ToList();
            var startParseInfos = includes
                .Select(x => new StartParseInfo(x.ToArray(),
                    Path.Combine(OutputDirectoryPath!, Path.GetFileName(x.Key)! + ".cs"),
                    "OpenHarmony.NDK.CAPI.Internal",
                    Path.GetFileName(x.Key)!))
                .ToList();

            GenerationProgressEndValue = startParseInfos.Count;
            _generationLogList.Clear();
            foreach (var startParseInfo in startParseInfos)
            {
                var task = C99APIParseProvide.StartParse(
                    NDK_CAPI_SysRootDirPath!,
                    NDK_CAPI_LlvmIncludeDirPath!,
                    startParseInfo);
                GenerationProgress++;
                if (task is null)
                    continue;
                var str = await task.StandardOutput.ReadToEndAsync();
                await task.WaitForExitAsync();
                Notification notification = new()
                {
                    Title = $"{startParseInfo.MethodClassName}",
                    Content = str,
                    Type = str.Contains("due to one or more errors listed above.")
                        ? NotificationType.Error
                        : NotificationType.Success
                };
                _generationLogList.Add(notification);
            }
        }
        catch (Exception e)
        {
            MessageBus.Current.SendMessage(e);
        }
        finally
        {
            LoadingMessage = BusyType.None;
            GenerationProgress = 0;
        }
    }
}