namespace AbstractFactoryApp.Models.Animals;

public class RoboDog : Dog {
    public RoboDog() : base("Robo Dog") { }

    public override void Say() {
        Console.WriteLine("H-U-F");
    }
}