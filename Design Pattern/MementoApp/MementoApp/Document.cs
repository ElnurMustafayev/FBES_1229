namespace MementoApp {
    public class Document {
        public string Title { get; set; }
        public string Content { get; set; }

        public DocumentMemento Save() {
            return new DocumentMemento() { 
                Title = this.Title,
                Content = this.Content
            };
        }

        public void Load(DocumentMemento memento) {
            this.Title = memento.Title;
            this.Content = memento.Content;
        }

        public void Show() {
            Console.WriteLine($"Title: {this.Title}\n");
            Console.WriteLine($"Content: \n{this.Content}");
        }
    }
}
