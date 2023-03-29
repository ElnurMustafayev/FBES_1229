namespace FactoryMethodApp.Models;

public class Card {
    public string Name { get; set; }
    public decimal Balance { get; set; }

    public override string ToString() => $"{this.Name}: {this.Balance}";
}