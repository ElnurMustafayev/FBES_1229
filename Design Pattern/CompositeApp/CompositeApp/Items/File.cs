namespace CompositeApp.Items {
    public class File : Component {
        public string Name { get; set; }
        public string? Content { get; set; }

        public File(string name, string? content = null) {
            this.Name = name;
            this.Content = content;
        }

        public override int Size => this.Content?.Length ?? 0;

        public override void Display(int depth = 0) {
            Console.WriteLine($"{new string(' ', depth)}{Name}");
        }
    }
}
