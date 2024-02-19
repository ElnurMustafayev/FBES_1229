using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorApp.Models;

namespace MediatorApp.Services.Base
{
    public interface IUserService
    {
        void Registration(User newUser);
        User Get(int id);
    }
}