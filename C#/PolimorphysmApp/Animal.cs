namespace Animals {
    abstract class Animal {
        private int fullness = 0;
        public string name;

        public int Fullness {
            get {
                return this.fullness;
            }
            protected set {
                if (value < 0)
                    return;

                const int maxFullness = 100;
                if(this.Fullness < maxFullness) {
                    this.fullness = value > maxFullness
                        ? maxFullness
                        : value;
                }
            }
        }

        public virtual int MyProperty { get; set; }

        //public virtual void Eat() {
        //    Console.WriteLine("Virtual method...");
        //}

        public abstract void Eat();

        public Animal(string name) {
            this.name = name;
        }
    }
}