using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorApp.Models;

namespace MediatorApp.Repositories.Base
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User GetUser(int id);
    }
}