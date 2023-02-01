using InterfacesApp.Animals.Interfaces;

namespace InterfacesApp.Animals;

class Shark : ISwimable {
    public void Swim() {
        Console.WriteLine("Shark is swimming...");
    }
}