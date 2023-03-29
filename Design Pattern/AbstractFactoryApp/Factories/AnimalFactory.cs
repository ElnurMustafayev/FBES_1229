using AbstractFactoryApp.Factories.Base;
using AbstractFactoryApp.Models.Animals;
using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Factories;

public class AnimalFactory : IAnimalFactory {
    public Cat GetCat() {
        var result = new Cat();

        Console.WriteLine($"{result.Name} was created by {nameof(AnimalFactory)}!");

        return result;
    }

    public Dog GetDog() {
        var result = new Dog();

        Console.WriteLine($"{result.Name} was created by {nameof(AnimalFactory)}!");

        return result;
    }

    public Horse GetHorse() {
        var result = new Horse();

        Console.WriteLine($"{result.Name} was created by {nameof(AnimalFactory)}!");

        return result;
    }
}