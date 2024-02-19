using MediatorApp.Models;

namespace MediatorApp.Repositories.Base
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User GetUser(int id);
        IEnumerable<User> GetAll();
    }
}