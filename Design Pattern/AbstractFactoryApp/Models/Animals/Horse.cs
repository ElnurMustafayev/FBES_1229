using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Models.Animals;

public class Horse : Animal {
    public Horse() : base("Horse") { }
    public Horse(string name) : base(name) { }

    public override void Say() {
        Console.WriteLine("ti-gi-dik");
    }
}
