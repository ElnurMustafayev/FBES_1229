using AbstractFactoryApp.Models.Animals;

namespace AbstractFactoryApp.Factories.Base;

public interface IAnimalFactory {
    Cat GetCat();
    Dog GetDog();
    Horse GetHorse();
}