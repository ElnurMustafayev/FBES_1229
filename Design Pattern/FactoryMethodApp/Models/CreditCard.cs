namespace FactoryMethodApp.Models;

public class CreditCard : Card {
    public string? Currency { get; set; }
    public string CVV { get; private set; }

    public CreditCard() {
        this.CVV = new Random().Next(0, 999).ToString("d3");
    }

    public override string ToString() {
        string message = @$"Name: {this.Name}
{nameof(Balance)}: {this.Balance}; {nameof(Currency)}: {this.Currency ?? "None"}";

        return message;
    }
        
}