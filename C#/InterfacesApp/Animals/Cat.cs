using InterfacesApp.Animals.Interfaces;

namespace InterfacesApp.Animals;

class Cat : IWalkable, ISwimable {
    public string Name { get; set; }

    public Cat(string name) {
        this.Name = name;
    }

    public void Eat() {

    }

    public void Walk() {
        Console.WriteLine("Cat is walking...");
    }

    public virtual void Swim() {
        Console.WriteLine("Cat is swimming...");
    }
}


class RoboCat : Cat {
    public RoboCat(string name) : base(name) {
    }

    public override void Swim() {
        Console.WriteLine("RoboCat is swimming...");
    }
}
