namespace BlogApp;

using BlogApp.ViewModels.Base;
using BlogApp.ViewModels;
using System.Windows;
using SimpleInjector;
using BlogApp.Messager.Services.Base;
using BlogApp.Messager.Services;

public partial class App : Application {
    public static Container ServiceContainer { get; set; } = new Container();

    protected override void OnStartup(StartupEventArgs e) {
        base.OnStartup(e);

        ConfigureContainer();

        StartWindow<LoginViewModel>();
    }

    private void ConfigureContainer() {
        ServiceContainer.RegisterSingleton<IMessenger, Messenger>();

        ServiceContainer.RegisterSingleton<MainViewModel>();
        ServiceContainer.RegisterSingleton<LoginViewModel>();

        ServiceContainer.Verify();
    }

    private void StartWindow<T>() where T : ViewModelBase {
        var startView = new MainWindow();

        var startViewModel = ServiceContainer.GetInstance<MainViewModel>();
        startViewModel.ActiveViewModel = ServiceContainer.GetInstance<T>();
        startView.DataContext = startViewModel;

        startView.ShowDialog();
    }
}