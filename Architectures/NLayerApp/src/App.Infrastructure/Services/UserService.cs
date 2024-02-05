using App.Core.Repositories;
using App.Core.Services;

namespace App.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool IsAnyUser()
        {
            var user = this.userRepository.GetUser();

            return user != null;
        }
    }
}