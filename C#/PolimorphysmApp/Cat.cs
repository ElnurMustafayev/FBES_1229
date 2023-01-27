namespace Animals {
    class Cat : Animal {
        public int tailLength = 0;

        public Cat(string name) : base(name) { }

        public override void Eat() {
            //this.Eat();
            //base.Eat();

            //throw new NotImplementedException();
            Console.WriteLine("Cat is eating...");
            this.Fullness += 60;
        }

        public override int MyProperty {
            get {
                return 0;
            }
            set {
            }
        }
    }
}
