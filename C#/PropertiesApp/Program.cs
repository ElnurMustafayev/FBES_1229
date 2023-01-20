using System;
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
            this.name = name;
            this.age = age;
        }

        // property
        public int Age { 
            get {
                Console.WriteLine("Getter");
                return this.age;
            }
            set {
                Console.WriteLine("Setter");
            }
        }

        //public void SetAge(int age) {
        //    this.age = age;
        //}
        //public int GetAge() {
        //    return this.age;
        //}

        //public void SetName(string name) {
        //    this.name = name;
        //}
        //public string GetName() {
        //    return this.name;
        //}
    }

    class Program {

        static void Func(int num) {
            Random random = new Random();
            num = random.Next(100);
        }

        static void Main(string[] args) {
            Person p = new Person("Bob", 45);

            int num = p.Age;            // getter
            int result = p.Age + num;   // getter
            Func(p.Age);                // getter
            Console.WriteLine(p.Age);   // getter


            p.Age = 123;                // setter










            if (false) {
                Card card = new Card("4102456123789546");
                Console.WriteLine(card.GetPincode());
                Console.WriteLine(card.GetPincode());

                card.SetPincode("5489123478980021");
                Console.WriteLine(card.GetPincode());
                Console.WriteLine(card.GetPincode());
            }
        }
    }
}