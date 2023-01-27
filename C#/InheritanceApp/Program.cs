namespace InheritanceApp {

    class Test {
        public Test(string salam) { }
    }

    class Animal : Test {
        public string name;
        public DateTime birthdate;

        public Animal(string name, DateTime birthdate) : base("test") {
            this.name = name;
            this.birthdate = birthdate;
        }
    }

    class Cat : Animal {
        public double tailLength;

        public Cat() : base("Rijik", new DateTime(2018, 08, 23)) { }
        public Cat(string name, DateTime birthdate) : base(name, birthdate) { }
    }

    class Program {
        static void Main() {
            Cat cat = new Cat();
        }
    }
}