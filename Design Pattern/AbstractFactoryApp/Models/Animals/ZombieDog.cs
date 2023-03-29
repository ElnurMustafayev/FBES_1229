namespace AbstractFactoryApp.Models.Animals;

public class ZombieDog : Dog {
    public ZombieDog() : base("Zombie dog") { }

    public override void Say() => Console.WriteLine("Hu... BRAINS");
}
