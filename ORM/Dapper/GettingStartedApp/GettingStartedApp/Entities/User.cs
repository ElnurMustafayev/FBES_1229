namespace GettingStartedApp.Entities;

public class User {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"[{Id}] {Name} {Age} years old";
}