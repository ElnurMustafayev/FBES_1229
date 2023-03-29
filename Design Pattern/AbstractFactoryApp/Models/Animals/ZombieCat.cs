namespace AbstractFactoryApp.Models.Animals;

public class ZombieCat : Cat {
    public ZombieCat() : base("Zombie cat") { }

    public override void Say() => Console.WriteLine("Me... BRAINS");
}