
using MediatorApp.Models;
using MediatorApp.Repositories.Base;

namespace MediatorApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            System.Console.WriteLine("Created");
        }

        public IEnumerable<User> GetAll()
        {
            return new List<User> {
                User.Create(),
                User.Create(),
                User.Create(),
            };
        }

        public User GetUser(int id)
        {
            return new User() {
                Id = id,
                Name = "Bob",
                Age = 66
            };
        }
    }
}