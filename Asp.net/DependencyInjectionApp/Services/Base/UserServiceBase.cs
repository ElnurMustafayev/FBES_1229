using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionApp.Services.Base
{
    public abstract class UserServiceBase
    {
        public abstract int GetUsersCount();
    }
}