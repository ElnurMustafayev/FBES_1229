using MediatorApp.Models;
using MediatorApp.Repositories.Base;
using MediatorApp.Services.Base;

namespace MediatorApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Get(int id)
        {
            return this.userRepository.GetUser(id);
        }

        public void Registration(User newUser)
        {
            this.userRepository.CreateUser(newUser);
        }
    }
}