using App.Core.Models;
using App.Core.Repositories;

namespace App.Infrastructure.Repositories
{
    public class UserFakeRepository : IUserRepository
    {
        public User GetUser()
        {
            return new User() {
                Firstname = "Test",
                Lastname = "Test"
            };
        }
    }
}