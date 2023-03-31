using System;
using System.Text.Json;

namespace PrototypeApp;

public class IdInfo {
    public int Id;

    public IdInfo(int id) => Id = id;

    public IdInfo() { }
}

public class User : IClonable<User> {

    private static int UserIdCounter = 0;
    public IdInfo IdInfo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool? IsMarried { get; set; }

    public User() {
        Console.WriteLine("Log: Default data read from file...");

        var defaultString = File.ReadAllText("Default.txt");

        this.IdInfo = new IdInfo(User.UserIdCounter++);
        this.Name = defaultString;
        this.Surname = defaultString;
        this.Age = 0;
        this.IsMarried = null;
    }

    //protected User(string name, string surname, int age, bool? ısMarried) {
    //    this.Name = name;
    //    this.Surname = surname;
    //    this.Age = age;
    //    this.IsMarried = isMarried;
    //}

    public override string ToString() {
        return $@"#{this.IdInfo.Id}. {nameof(Name)}: {Name}
{nameof(Surname)}: {Surname}
{nameof(Age)}: {Age}
{nameof(IsMarried)}: {IsMarried}";
    }

    public User Clone() {
        var result = (this.MemberwiseClone() as User);

        result.IdInfo = new IdInfo(this.IdInfo.Id);

        return result;

        //return new User(this.Name, this.Surname, this.Age, this.IsMarried);
    }
}