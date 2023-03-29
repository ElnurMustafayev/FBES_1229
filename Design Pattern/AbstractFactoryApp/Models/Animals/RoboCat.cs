namespace AbstractFactoryApp.Models.Animals;

public class RoboCat : Cat {
    public RoboCat() : base("Robo Cat") { }

    public override void Say() {
        Console.WriteLine("M-E-O-W");
    }
}
