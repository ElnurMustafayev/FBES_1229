using DependencyInjectionApp.Models;

namespace DependencyInjectionApp.Repositories.Base
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
    }
}