namespace GCApp;

class Program {
    static void Main() {
        string str = "qwerty";

        Console.WriteLine($"str's generation: {GC.GetGeneration(str)}");
        
        GC.Collect();
        GC.Collect();
        
        Console.WriteLine($"str's generation: {GC.GetGeneration(str)}");

        GC.Collect();
        GC.Collect();

        Console.WriteLine($"str's generation: {GC.GetGeneration(str)}");
    }
}