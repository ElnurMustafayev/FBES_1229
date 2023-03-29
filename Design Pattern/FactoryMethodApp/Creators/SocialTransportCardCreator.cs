using FactoryMethodApp.Models;

namespace FactoryMethodApp.Creators {
    public class SocialTransportCardCreator : ICardCreator {
        public Card Create() => new TransportCard() {
            Name = "Social Transport Card",
            Balance = 0,
            IsSpecial = true,
        };

        public void ShowNewCardTemplate() {
            Console.WriteLine("This is social TransportCard");
            Console.WriteLine("All Trips are free!");

            var card = this.Create();
            Console.WriteLine(card.ToString());
        }
    }
}
