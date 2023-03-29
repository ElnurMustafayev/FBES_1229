using FactoryMethodApp.Creators;

namespace FactoryMethodApp.Models {
    public class User {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Card> Cards { get; set; }

        public User(string name, string surname) {
            Name = name;
            Surname = surname;

            Cards = new List<Card>();
        }

        public void AddCard(Card card) {
            Cards.Add(card);
            Console.WriteLine("Card was add");
        }

        public void AddCard(ICardCreator cardCreator) {
            Console.WriteLine($"Creator {cardCreator.GetType().Name}");
            this.AddCard(cardCreator.Create());
        }

        public void ShowInfo() {
            Console.WriteLine($"{this.Surname} {this.Name}");

            if (this.Cards == null || this.Cards.Count == 0)
                return;

            Console.WriteLine();

            foreach (var card in this.Cards) {
                Console.WriteLine(card);
            }
        }
    }
}
