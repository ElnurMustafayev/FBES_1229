using DependencyInjectionApp.Services.Base;

namespace DependencyInjectionApp.Services;

public class UserSqlService : IUserService {
    public void Do() {
        Console.WriteLine("UserSqlService doing something...");
    }
}