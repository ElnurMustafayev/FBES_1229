using Animals;

namespace PolimorphysmApp {
    class Program {
        static void Main() {
            Animal animal = new Cat("Barsik");

            animal.Eat();
            Console.WriteLine(animal.Fullness);
            animal.Eat();
            Console.WriteLine(animal.Fullness);
            animal.Eat();
            Console.WriteLine(animal.Fullness);
        }
    }
}