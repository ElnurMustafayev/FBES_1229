using System.Data.SqlClient;
using System.Drawing;
using System.Text.Json;

namespace JsonApp;

public class Program {
    const string filename = "user.json";


    static void Main() {
        if(true) {
            var json = File.ReadAllText("user.json");
            var user = JsonSerializer.Deserialize<User>(json);
            user.Cars[1].MaxSpeed += 20;
            var resultJson = JsonSerializer.Serialize(user);
            File.WriteAllText("user.json", resultJson);
        }

        if(false) {
            var json = File.ReadAllText("user.json");
            var user = JsonSerializer.Deserialize<User>(json);
            Console.WriteLine(user);
        }

        if(false) {
            var user = new User {
                Name = "John",
                Surname = "Black",
                Age = 28,
                Gender = GENDERS.Male,
                Cars = new List<Car> {
                    new Car() {
                        Name = "BMW M5",
                        MaxSpeed = 330,
                    },
                    new Car() {
                        Name = "Lada",
                        MaxSpeed = 80,
                    }
                },
            };

            var json = JsonSerializer.Serialize(user);
            File.WriteAllText("user.json", json);
        }

        if(false) {
            var json = File.ReadAllText("users_storage.json");
            UserStorage storage = JsonSerializer.Deserialize<UserStorage>(json);

            var user = storage.Users[2];

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Surname);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Gender);
        }

        if(false) {
            {
                List<User> users = new List<User>() {
                    User.Generate(),
                    User.Generate(),
                    User.Generate(),
                    User.Generate(),
                    User.Generate(),
                };

                var json = JsonSerializer.Serialize(users);
                File.WriteAllText("users_array.json", json);
            }

            {
                var storage = new UserStorage() {
                    Users = new List<User>() {
                        User.Generate(),
                        User.Generate(),
                        User.Generate(),
                        User.Generate(),
                        User.Generate(),
                    },
                    Count = 5,
                };

                var json = JsonSerializer.Serialize(storage);
                File.WriteAllText("users_storage.json", json);
            }
        }



        if(false) {
            string json = File.ReadAllText(filename);

            User user = JsonSerializer.Deserialize<User>(json);

            Console.WriteLine(user);
        }


        if(false) {
            var user = new User {
                Name = "John",
                Surname = "Black",
                Age = 28,
                Gender = GENDERS.Male,
            };

            string json = JsonSerializer.Serialize(user);

            File.WriteAllText(filename, json);
        }



        if(false) {
            var lines = File.ReadAllLines("data.txt");

            var users = new List<User>();
            foreach (var line in lines) {
                var datas = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                var user = new User {
                    Name = datas[0],
                    Surname = datas[1],
                    Age = int.Parse(datas[2]),
                    Gender = (GENDERS)int.Parse(datas[3]),
                };

                users.Add(user);
            }

            Console.WriteLine(users.Count);
        }
    }
}