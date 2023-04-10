using StrategyApp.Strategies.Base;

namespace StrategyApp.Strategies {
    public class UserStrategyA : IUserStrategy {
        public IEnumerable<User> GetUsers() {
            return new List<User>() {
                new User("Bob"),
                new User("Ann"),
                new User("John"),
            };
        }

        public User? SelectOne(IEnumerable<User> users) {
            return users.FirstOrDefault();
        }
    }
}
