using InterfacesApp.Animals.Interfaces;

namespace InterfacesApp.Animals;

class Parrot : IFlyable, IWalkable {
    public string Name { get; set; }

    public double Speed {
        get {
            return new Random().NextDouble();
        }
    }

    public Parrot(string name) {
        this.Name = name;
    }

    public void Fly() {
        Console.WriteLine("Parrot is fling...");
    }

    public void Walk() {
        Console.WriteLine("Parrot is walking...");
    }
}