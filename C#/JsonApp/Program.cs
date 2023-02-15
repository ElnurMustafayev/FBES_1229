using System.Text.Json;

namespace JsonApp;

public class Program {
    static void Main() {
        if(true) {
            var user = new User {
                Name = "John",
                Surname = "Black",
                Age = 28,
                Gender = GENDERS.Male,
            };

            string json = JsonSerializer.Serialize(user);
            File.WriteAllText("data.txt", json);
        }



        if(false) {
            var lines = File.ReadAllLines("data.txt");

            var users = new List<User>();
            foreach (var line in lines) {
                var datas = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                var user = new User {
                    Name = datas[0],
                    Surname = datas[1],
                    Age = uint.Parse(datas[2]),
                    Gender = (GENDERS)int.Parse(datas[3]),
                };

                users.Add(user);
            }

            Console.WriteLine(users.Count);
        }
    }
}