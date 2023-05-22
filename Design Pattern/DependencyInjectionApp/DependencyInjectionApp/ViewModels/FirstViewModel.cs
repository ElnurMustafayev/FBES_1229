using DependencyInjectionApp.Services;
using DependencyInjectionApp.Services.Base;

namespace DependencyInjectionApp.ViewModels;

public class FirstViewModel {
    IUserService userService; // = new UserFileService();

    public FirstViewModel(IUserService userService) {
        this.userService = userService;
    }

    public void Func() {
        userService.Do();
    }
}