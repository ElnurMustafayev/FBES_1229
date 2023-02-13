namespace GuidApp {
    public class Program {
        static void Main() {
            Guid generatedGuid = Guid.NewGuid();
            string guidStr = generatedGuid.ToString("X");

            Console.WriteLine(generatedGuid.ToString("D"));
            Console.WriteLine(generatedGuid.ToString("X"));
        }
    }
}