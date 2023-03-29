using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Models.Animals;

public class Dog : Animal {
    public Dog() : base("Dog") { }
    public Dog(string name) : base(name) { }

    public override void Say() => Console.WriteLine("Huf");
}