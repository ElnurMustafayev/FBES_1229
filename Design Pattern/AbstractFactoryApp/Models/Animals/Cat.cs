using AbstractFactoryApp.Models.Animals.Base;

namespace AbstractFactoryApp.Models.Animals;

public class Cat : Animal {
    public Cat() : base("Cat") { }
    public Cat(string name) : base(name) { }
    public override void Say() => Console.WriteLine("Meow");
}