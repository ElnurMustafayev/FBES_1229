using StrategyApp.Strategies.Base;
using System.Text.Json;

namespace StrategyApp.Strategies {
    public class UserStrategyB : IUserStrategy {
        public IEnumerable<User>? GetUsers() {
            const string filepath = "users.json";

            if (File.Exists(filepath) == false)
                return Enumerable.Empty<User>();

            var json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<IEnumerable<User>>(json);
        }

        public User? SelectOne(IEnumerable<User> users) {
            return users.ElementAt(new Random().Next(users.Count()));
        }
    }
}
