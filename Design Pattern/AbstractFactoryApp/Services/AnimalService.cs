using AbstractFactoryApp.Factories.Base;
using AbstractFactoryApp.Models.Animals;

namespace AbstractFactoryApp.Services;

public class AnimalService {
    public IAnimalFactory AnimalFactory { get; set; }

    public AnimalService(IAnimalFactory animalFactory) {
        this.AnimalFactory = animalFactory;
    }

    public Cat GetCat() {
        var result = AnimalFactory.GetCat();

        result.Say();

        return result;
    }

    public Dog GetDog() {
        var result = AnimalFactory.GetDog();

        result.Say();

        return result;
    }

    public Horse GetHorse() {
        var result = AnimalFactory.GetHorse();

        result.Say();

        return result;
    }
}