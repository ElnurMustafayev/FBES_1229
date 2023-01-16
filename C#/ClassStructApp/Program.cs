using System.Xml.Linq;

namespace ClassStructApp {
    enum CAR_TYPES {
        hatchbag,
        sedan,
        jeep
    };

    struct Person {
        public string name;
        public int age;
        private string password;
        Car[] cars;
    }

    class Car {
        Person driver;
        public string name;
        public CAR_TYPES type;
        public double speed;
        string serialNumber;
    }

    enum GENERATION_TYPES {
        teenager,
        adult,
        unknown,
        elder
    };

    class Transport {
        public string name;
        public Passenger driver;
        public Passenger[] passengers;
    }

    struct Passenger {
        public string name;
        public string surname;
        public GENERATION_TYPES type;
    }

    class Cat {
        string name = "";

        public Cat(string name) {
            this.SetName(name);
        }

        private void SetName(string name) {
            if (!string.IsNullOrWhiteSpace(name))
                this.name = name.Trim();
        }

        public void Say() {
            Console.WriteLine("Meow");
        }

        public string GetNormalizedName() {
            if (string.IsNullOrWhiteSpace(this.name))
                return string.Empty;

            string normalizedName = this.name.Trim();

            if(normalizedName.Length <= 1)
                return $"{char.ToUpper(normalizedName[0])}";

            string result = char.ToUpper(normalizedName[0]) + normalizedName.Substring(1).ToLower();

            return result;
        }
    }

    struct Dog {
        public int age;
        public string name;

        public Dog(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }

    class Program {
        static void Main(string[] args) {
            if(false) {
                bool isUpPressed = Console.ReadKey().Key == ConsoleKey.UpArrow;

                // green background
                // red foreground

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("Test1");

                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Test2");

                Console.ResetColor();

                Console.Clear();
            }

            if (false) {
                Cat cat = new Cat("rijiK");
                Console.Write($"{cat.GetNormalizedName()} says: "); cat.Say();
            }

            if (false) {
                Passenger p1 = new Passenger();
                p1.name = "Elnur";
                p1.surname = "Mustafayev";
                p1.type = GENERATION_TYPES.adult;

                Passenger p2 = new Passenger();
                p2.name = "Rufat";
                p2.surname = "Ahmadov";
                p2.type = GENERATION_TYPES.adult;

                Passenger p3 = new Passenger();
                p3.name = "Leyla";
                p3.surname = "Guliyeva";
                p3.type = GENERATION_TYPES.teenager;

                Passenger driver = new Passenger();
                driver.name = "Bob";
                driver.surname = "Black";
                driver.type = GENERATION_TYPES.unknown;

                Transport bus = new Transport();
                bus.name = "88 Bus";
                bus.driver = driver;
                bus.passengers = new Passenger[] {
                    p1, p2, p3
                };
            }

            if (false) {
                Car car = new Car();
                car.name = "BMW M3";

                Console.WriteLine($"Car's name: {car.name}");
            }

            if (false) {
                Person p = new Person();
                p.name = "Test";
                Console.WriteLine(p.name);
            }
        }
    }
}