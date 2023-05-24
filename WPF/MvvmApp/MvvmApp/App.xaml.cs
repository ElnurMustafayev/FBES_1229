using System.Windows;
using MvvmApp.Services;
using MvvmApp.Services.Base;
using MvvmApp.ViewModels;
using MvvmApp.ViewModels.Base;
using SimpleInjector;

namespace MvvmApp {
    public partial class App : Application {
        public static Container ServiceContainer { get; set; } = new Container();

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            ConfigureContainer();

            StartWindow<HomeViewModel>();
        }

        private void StartWindow<T>() where T : ViewModelBase {
            var startView = new MainWindow();

            var startViewModel = ServiceContainer.GetInstance<MainViewModel>();
            startViewModel.ActiveViewModel = ServiceContainer.GetInstance<T>();
            startView.DataContext = startViewModel;

            startView.ShowDialog();
        }

        private void ConfigureContainer() {
            ServiceContainer.RegisterSingleton<IMessenger, Messenger>();

            ServiceContainer.RegisterSingleton<HomeViewModel>();
            ServiceContainer.RegisterSingleton<MainViewModel>();
            ServiceContainer.RegisterSingleton<SecondViewModel>();

            ServiceContainer.Verify();
        }
    }
}