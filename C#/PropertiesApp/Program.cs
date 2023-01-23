using System.Text;

namespace PropertiesApp {
    class Card {
        private string pincode = "0000000000000000";
        private string maskedPincode;

        public Card(string pincode) {
            this.SetPincode(pincode);
        }

        public void SetPincode(string pincode) {
            if(string.IsNullOrWhiteSpace(pincode) == false &&
                pincode.Trim().Length == 16 && 
                long.TryParse(pincode, out long result)) {

                this.pincode = pincode;
                this.maskedPincode = string.Empty;
            }
        }

        public string GetPincodeEasy() {
            return $"{this.pincode.Substring(0, 4)} **** **** ****";
        }

        public string GetPincode() {
            if (string.IsNullOrWhiteSpace(maskedPincode) == false) {
                Console.WriteLine("return MASKED");
                return maskedPincode;
            }

            StringBuilder sb = new StringBuilder(19);

            for (int i = 0; i < this.pincode.Length; i++) {
                if (i > 0 && i % 4 == 0)
                    sb.Append(' ');

                sb.Append(i < 4 ? this.pincode[i] : '*');
            }

            maskedPincode = sb.ToString();
            Console.WriteLine("return after logic");
            return maskedPincode;
        }
    }

    class Person {
        private string name;
        private int age;

        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
        }

        // properties
        public int Age { 
            get {
                Console.WriteLine("Getter");
                return this.age;
            }
            set {
                Console.WriteLine($"Setter {value}");
                this.age = value;
            }
        }

        public string Name {
            get {
                if (string.IsNullOrWhiteSpace(this.name))
                    return this.name;

                return char.ToUpper(this.name[0]) + this.name[1..].ToLower();
            }
            set {
                if(!string.IsNullOrWhiteSpace(value)) {
                    this.name = value;
                }
            }
        }
    }

    enum CURRENCIES {
        azn, rub, usd, euro
    }

    class Balance {
        public decimal Amount { get; set; }

        private CURRENCIES currency;
        public CURRENCIES Currency {
            get {
                return this.currency;
            } 
            set {
                if(value >= CURRENCIES.azn && value <= CURRENCIES.euro) {
                    this.currency = value;
                }
            }
        }

        public CURRENCIES GetCurrency() {
            return this.currency;
        }
        private void SetCurrency(CURRENCIES value) {
            if (value >= CURRENCIES.azn && value <= CURRENCIES.euro) {
                this.currency = value;
            }
        }
    }


    enum SUIT {
        diamonds,
        hearts,
        clubs,
        spades,
    }

    class GameCard {
        public SUIT Suit { get; private set; }

        private int value;
        public int Value {
            get { return this.value; }
            private set { this.value = value; }
        }

        public GameCard(SUIT suit, int value) {
            this.Suit = suit;
            this.Value = value;
        }

        public void Show() {
            Console.WriteLine($"{this.Value} {this.Suit}");
        }
    }


    class Program {
        static void Main(string[] args) {
            if(true) {
                GameCard card = new GameCard(SUIT.hearts, 14);
                Console.WriteLine(card.Suit);
                Console.WriteLine(card.Value);
            }

            if(false) {
                Balance balance = new Balance();
                balance.Amount = 123;
                balance.Currency = CURRENCIES.azn;
            }

            if(false) {
                Person p = new Person("Bob", 45);

                //int num = p.Age;              // getter
                //int result = p.Age + num;     // getter
                //Func(p.Age);                  // getter
                //Console.WriteLine(p.Age);     // getter

                //p.Age = 777;                    // setter
                //Console.WriteLine(p.Age);

                p.Name = "boB";
                Console.WriteLine(p.Name);
            }



            if (false) {
                Card card = new Card("4102456123789546");
                Console.WriteLine(card.GetPincode());
                Console.WriteLine(card.GetPincode());

                card.SetPincode("5489123478980021");
                Console.WriteLine(card.GetPincode());
                Console.WriteLine(card.GetPincode());
            }
        }

        static void Func(int num) {
            Random random = new Random();
            num = random.Next(100);
        }
    }
}