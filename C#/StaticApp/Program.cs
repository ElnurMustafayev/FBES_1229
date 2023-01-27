namespace StaticApp {
    static class Calc {
        public static string test;
        public static string ModelName { get; set; }

        public static double Sum(double num1, double num2) {
            return num1 + num2;
        }
        public static double Minus(double num1, double num2) {
            return num1 - num2;
        }

        public static void ShowInfo() {
            Console.WriteLine("CALC Info...");
            Console.WriteLine($"Modal: {ModelName}");
        }
    }

    class Person {
        public static int PeopleCount;
        public static string Name { get; set; }
        public static int counter = 0;

        public Person(string name) {
            Person.PeopleCount++;
            Name = name;
            counter += Name.Length;
        }
    }

    class Program {
        static void Main(string[] args) {
            var p1 = new Person("Bob");
            var p2 = new Person("Ann");
            var p3 = new Person("Jane");

            Console.WriteLine(Person.counter);







            //Calc.ModelName = "Casio";
            //Console.WriteLine(Calc.ModelName);

            //Calc calc = new Calc();
            //var result = Calc.Sum(10, 5);
            //Console.WriteLine(result);
        }
    }
}