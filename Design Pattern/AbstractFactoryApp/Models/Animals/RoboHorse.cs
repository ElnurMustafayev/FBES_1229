namespace AbstractFactoryApp.Models.Animals;

public class RoboHorse : Horse {
    public RoboHorse() : base("Robo Horse") { }

    public override void Say() {
        Console.WriteLine("T-I-G-I-D-I-K");
    }
}
