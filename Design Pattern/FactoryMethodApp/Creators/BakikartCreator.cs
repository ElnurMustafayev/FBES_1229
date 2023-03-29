using FactoryMethodApp.Models;

namespace FactoryMethodApp.Creators;

public class BakikartCreator : ICardCreator {
    public Card Create() => new TransportCard() {
        Name = "Bakikart",
        Balance = 0,
        IsSpecial = false,
    };

    public void ShowNewCardTemplate() {
        var card = this.Create();

        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine(card);
        Console.WriteLine("- - - - - - - - - - - - - - - -");
    }
}