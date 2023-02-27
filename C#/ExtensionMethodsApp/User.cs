namespace ExtensionMethodsApp;

public class User {
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public User(string name, string surname) {
        Name = name;
        Surname = surname;
    }

    public void Info() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"BirthDate: {BirthDate}");
    }
}