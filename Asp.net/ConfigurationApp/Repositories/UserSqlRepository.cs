using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationApp.Repositories.Base;

namespace ConfigurationApp.Repositories
{
    public class UserSqlRepository : IUserRepository
    {
        private readonly string connectionString;
        public UserSqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Test()
        {
            System.Console.WriteLine(this.connectionString);
        }
    }
}