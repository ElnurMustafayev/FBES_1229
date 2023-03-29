namespace AbstractFactoryApp.Models.Animals.Base;

public abstract class Animal {
    public string Name { get; set; }

    public Animal(string name) {
        Name = name;
    }

    public abstract void Say();
}
