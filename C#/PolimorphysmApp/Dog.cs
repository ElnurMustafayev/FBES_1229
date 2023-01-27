namespace Animals {
    class Dog : Animal {
        public Dog(string name) : base(name) {
        }

        public override void Eat() {
            Console.WriteLine("Dog is eating...");
            this.Fullness = this.Fullness + 15;
        }
    }
}
