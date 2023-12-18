using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services.Base;

namespace DependencyInjectionApp.Services
{
    public class UserService : UserServiceBase
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            System.Console.WriteLine("SERVICE: " + userRepository.GetHashCode());
            this.userRepository = userRepository;
            System.Console.WriteLine("UserService");
        }

        public override int GetUsersCount()
        {
            return this.userRepository.GetAllUsers().Count();
        }
    }
}