using AbstractFactoryApp.Factories.Base;
using AbstractFactoryApp.Models.Animals;

namespace AbstractFactoryApp.Factories;

public class RoboAnimalFactory : IAnimalFactory {
    public Cat GetCat() {
        return new RoboCat();
    }

    public Dog GetDog() {
        return new RoboDog();
    }

    public Horse GetHorse() {
        return new RoboHorse();
    }
}