using FactoryMethodApp.Models;

namespace FactoryMethodApp.Creators;

public class VipCreditCardCreator : ICardCreator {
    private readonly string currencyStr;
    private const string CardName = "VIP Special credit card";

    public VipCreditCardCreator(string currencyStr) {
        this.currencyStr = currencyStr;
    }

    public Card Create() => new CreditCard() {
        Name = CardName,
        Balance = 10_000,
        Currency = currencyStr,
    };


    public void ShowNewCardTemplate() {
        Console.WriteLine(this.Create());
    }
}