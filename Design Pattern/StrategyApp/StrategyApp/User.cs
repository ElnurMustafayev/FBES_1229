using System.Text.Json.Serialization;

namespace StrategyApp {
    public class User {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public User(string name) {
            this.Name = name;
        }
    }
}