namespace MementoApp {

    // caretaker
    public class DocumentHistory {
        private ICollection<DocumentMemento> mementos;  // saves
        private Document document;                      // originator

        public DocumentHistory(Document originator, ICollection<DocumentMemento>? mementos = null) {
            this.document = originator;
            this.mementos = mementos ?? new List<DocumentMemento>();
        }

        public void Save() {
            mementos.Add(document.Save());
        }

        public void Reset() {
            if (mementos.Any() == false)
                return;

            var lastSave = mementos.Last();
            mementos.Remove(lastSave);

            this.document.Load(lastSave);
        }
    }
}
