namespace MementoApp {
   class Program {
        static void Main() {
            Document document = new Document() {
                Title = "My Works",
                Content = @"1. Feed the cat
2. Feed the Dog
3. Eat
4. Go to sleep",
        };

            DocumentHistory history = new DocumentHistory(originator: document);
            history.Save();



            document.Title += " (without sleeping)";
            document.Content = @"1. Feed the cat
2. Feed the Dog
3. Eat";
            history.Save();



            document.Title = "";
            document.Content = @"1. Feed the cat
4. Feed the Dog
3. Eat";
            history.Save();



            document.Title = "Test";
            document.Content = @"";



            history.Reset();
            history.Reset();
            history.Reset();
            document.Show();
        }
    }
}