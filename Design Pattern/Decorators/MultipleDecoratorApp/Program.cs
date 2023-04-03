using MultipleDecoratorApp.Model.Decorators;
using MultipleDecoratorApp.Model.Weapons;

namespace MultipleDecoratorApp;

internal class Program {
    static void Main(string[] args) {
        Weapon pistol = new Pistol();

        Console.WriteLine("Default: " + pistol.Accuracy);

        pistol = new AimDecorator(pistol);

        Console.WriteLine("Aim: " + pistol.Accuracy);

        pistol = new ButtDecorator(pistol);

        Console.WriteLine("Aim & Butt: " + pistol.Accuracy);
    }
}