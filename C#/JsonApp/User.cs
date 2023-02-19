using System.Text.Json.Serialization;

namespace JsonApp;

public enum GENDERS : int {
    Male, Female, Other, Unknown,
}

public class User {
    [JsonPropertyName("first_name")]
    public string Name { get; set; }
    [JsonPropertyName("second_name")]
    public string Surname { get; set; }
    [JsonIgnore]
    public GENDERS Gender { get; set; }

    public int Age { get; set; }

    public List<Car> Cars { get; set; }

    public static User Generate() => new User() {
        Name = Guid.NewGuid().ToString(),
        Surname = Guid.NewGuid().ToString(),
        Age = new Random().Next(60),
        Gender = (GENDERS)new Random().Next(60),
    };
}