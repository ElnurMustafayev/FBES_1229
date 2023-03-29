namespace FactoryMethodApp.Models {
    public class TransportCard : Card {
        public bool IsSpecial { get; set; } = false;

        public override string ToString() => @$"Name: {this.Name}
{nameof(Balance)}: {this.Balance}; {nameof(IsSpecial)}: {this.IsSpecial}";
    }
}
