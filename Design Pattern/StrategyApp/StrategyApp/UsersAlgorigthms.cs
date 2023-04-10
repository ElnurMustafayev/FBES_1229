using StrategyApp.Strategies.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp {
    public class UsersAlgorigthms {
        private readonly IUserStrategy strategy;

        public UsersAlgorigthms(IUserStrategy strategy) {
            this.strategy = strategy;
        }

        public User SomeAlgorithm() {
            Console.WriteLine("Algorithm start...");

            var users = strategy.GetUsers();

            Console.WriteLine("Users:");

            if(users != null) {
                foreach (var user in users) {
                    Console.WriteLine(user.Name);
                }
            }

            Console.WriteLine("Middle algorithm logic");

            var selectedUser = strategy.SelectOne(users);

            return selectedUser;
        }
    }
}
