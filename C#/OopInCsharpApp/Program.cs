namespace OopInCsharpApp {
    class Animal {
        public string name;
        public DateTime birthdate;

        private void Method() {
        }
    }

    class Cat : Animal {
        public double tailLength;

        public Cat() {
        }
    }

    class Program {
        static void Main() {
            Animal animal = new Animal();
            Cat cat = new Cat();
        }
    }
}