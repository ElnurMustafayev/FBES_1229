using DependencyInjectionApp.Services.Base;

namespace DependencyInjectionApp.Services;

public class UserFileService : IUserService {
    public void Do() {
        Console.WriteLine("UserFileService doing something...");
    }
}