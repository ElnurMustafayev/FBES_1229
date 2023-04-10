namespace MementoApp {
    public class DocumentMemento {
        public readonly DateTime CreationDate;
        public string Title { get; set; }
        public string Content { get; set; }

        public DocumentMemento() {
            this.CreationDate = DateTime.Now;
        }
    }
}
