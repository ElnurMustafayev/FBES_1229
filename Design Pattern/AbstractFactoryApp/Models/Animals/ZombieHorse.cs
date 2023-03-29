using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Models.Animals;

public class ZombieHorse : Horse {
    public ZombieHorse() : base("Zombie Horse") { }

    public override void Say() {
        Console.WriteLine("ti-gi-BRAINSSSSS...");
    }
}