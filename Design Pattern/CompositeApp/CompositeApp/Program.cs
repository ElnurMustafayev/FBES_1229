using CompositeApp.Composits;

namespace CompositeApp {
    using CompositeApp.Items;

    public class Program {
        static void Main() {
            Folder catsFolder = new Folder("cats");
            File cat1 = new File("cat1.txt", "first cat content... txt meow");
            File cat2 = new File("cat2.txt", "the second cat content...");
            File cat3 = new File("cat3.txt", "meow");
            catsFolder.AddItem(cat1);
            
            Folder rijikFolder = new Folder("rijik");
            File rijik = new File("rijik.png", "ajhsdvasjhdajshdgjg837b6t8362tc7623tcb7623btc76r2bt37r2bt736brc7263cbt723");
            rijikFolder.AddItem(rijik);

            Folder folder = new Folder("leto 2012");
            folder.AddItem(new File("pic1.png", "qwertyuyio"));
            folder.AddItem(new File("pic2.png", "qwertyuyio132123"));
            folder.AddItem(new File("pic3.png", "24457qwertyuyio"));
            rijikFolder.AddItem(folder);

            catsFolder.AddItem(rijikFolder);

            catsFolder.AddItem(cat2);
            catsFolder.AddItem(cat3);

            catsFolder.Display();

            //Console.WriteLine(catsFolder.Size);
            //Console.WriteLine(rijikFolder.Size);
            //Console.WriteLine(folder.Size);
        }
    }
}