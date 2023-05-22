using DependencyInjectionApp.Services.Base;
using DependencyInjectionApp.Services;

namespace DependencyInjectionApp.ViewModels;

public class SecondViewModel {
    IUserService userService; // = new UserFileService();

    public SecondViewModel(IUserService userService) {
        this.userService = userService;
    }

    public void Func() {
        userService.Do();
    }
}