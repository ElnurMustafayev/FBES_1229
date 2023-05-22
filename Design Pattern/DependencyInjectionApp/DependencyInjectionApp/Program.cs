using DependencyInjectionApp.Services;
using DependencyInjectionApp.Services.Base;
using DependencyInjectionApp.ViewModels;

using SimpleInjector;

namespace DependencyInjectionApp {
    public class Program {
        static void Main() {
            Container container = new Container();

            container.RegisterSingleton<IUserService, UserFileService>();
            container.RegisterSingleton<FirstViewModel>();
            container.RegisterSingleton<SecondViewModel>();

            container.Verify();

            container.RegisterSingleton<IUserService, UserSqlService>();

            //var vm = new FirstViewModel(new UserSqlService());

            //vm.Func();
        }
    }
}