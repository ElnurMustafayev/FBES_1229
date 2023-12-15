using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;

namespace DependencyInjectionApp.Repositories
{
    public class UserFileRepository : IUserRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            return new List<User> {
                new User {
                    Name = "Bob",
                    Surname = "Marley",
                }
            };
        }
    }
}