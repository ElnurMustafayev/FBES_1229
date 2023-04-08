namespace CompositeApp.Composits {
    public class Folder : Component {
        public string Name { get; set; }
        private List<Component> items = new List<Component>();
        public override int Size => this.items.Sum(item => item.Size);

        public Folder(string name) {
            this.Name = name;
        }

        public void AddItem(Component item) {
            this.items.Add(item);
        }

        public override void Display(int depth = 0) {
            Console.WriteLine($"{new string(' ', depth)}{this.Name}");
            foreach (var item in this.items) {
                item.Display(depth + 2);
            }
        }
    }
}
