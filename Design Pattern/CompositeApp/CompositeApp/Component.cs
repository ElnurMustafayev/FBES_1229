namespace CompositeApp {
    public abstract class Component {
        public abstract int Size { get; }

        public abstract void Display(int depth = 0);
    }
}
