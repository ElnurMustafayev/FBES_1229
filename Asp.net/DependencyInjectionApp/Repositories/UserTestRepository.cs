using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;

namespace DependencyInjectionApp.Repositories
{
    public class UserTestRepository : IUserRepository
    {
        public UserTestRepository()
        {
            System.Console.WriteLine("UserTestRepository");
        }
        public IEnumerable<User> GetAllUsers()
        {
            return new List<User> {
                new User(),
                new User(),
                new User(),
                new User(),
                new User(),
            };
        }
    }
}