using AbstractFactoryApp.Factories;
using AbstractFactoryApp.Models.Animals;
using AbstractFactoryApp.Services;
using System.Data.Common;

namespace AbstractFactoryApp;

public class Program {
    static void Main() {
        // BAD
        //var animalService = new AnimalService();

        //animalService.GetCat();
        //animalService.GetCat();
        //animalService.GetCat();
        //animalService.GetDog();
        //animalService.GetDog();



        // GOOD
        var animalService = new AnimalService(
            animalFactory: new AnimalFactory()
            );

        Console.WriteLine(animalService.GetCat().ToString());
        Console.WriteLine(animalService.GetDog().ToString());
        Console.WriteLine(animalService.GetHorse().ToString());

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

        animalService.AnimalFactory = new ZombieAnimalFactory();

        Console.WriteLine(animalService.GetCat().ToString());
        Console.WriteLine(animalService.GetDog().ToString());
        Console.WriteLine(animalService.GetHorse().ToString());

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

        animalService.AnimalFactory = new RoboAnimalFactory();

        Console.WriteLine(animalService.GetCat().ToString());
        Console.WriteLine(animalService.GetDog().ToString());
        Console.WriteLine(animalService.GetHorse().ToString());
    }
}