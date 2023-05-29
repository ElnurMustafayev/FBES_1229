namespace ParametersApp.Entities;

public class Student {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public override string ToString() => $"#{Id}: {Name} {Surname}";
    public override int GetHashCode() => Id;
}
