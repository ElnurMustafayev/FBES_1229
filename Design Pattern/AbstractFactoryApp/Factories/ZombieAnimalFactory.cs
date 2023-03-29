using AbstractFactoryApp.Factories.Base;
using AbstractFactoryApp.Models.Animals;
using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Factories;

public class ZombieAnimalFactory : IAnimalFactory {
    public Cat GetCat() {
        var result = new ZombieCat();

        Console.WriteLine($"{result.Name} was created by {nameof(ZombieAnimalFactory)}!");

        return result;
    }

    public Dog GetDog() {
        var result = new ZombieDog();

        Console.WriteLine($"{result.Name} was created by {nameof(ZombieAnimalFactory)}!");

        return result;
    }

    public Horse GetHorse() {
        var result = new ZombieHorse();

        Console.WriteLine($"{result.Name} was created by {nameof(ZombieAnimalFactory)}!");

        return result;
    }
}
