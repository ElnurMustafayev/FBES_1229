using IteratorApp.Iterators;

namespace IteratorApp {
    public class Program {
        static void Main() {
            var students = new List<Student>() {
                new Student("Deniz", "Demirel"),
                new Student("Diana", "Ahadova"),
                new Student("Zabil", "Khasayli"),
            };

            var iterator = new ByNameIterator(students);
            var group = new StudentGroup("FBES_1229_ru", students, iterator);

            Console.WriteLine("By name: ");

            foreach (var student in group) {
                Console.WriteLine(student);
            }

            Console.WriteLine("By Surname: ");
            group.iterator = new BySurnameIterator(students);
            foreach (var student in group) {
                Console.WriteLine(student);
            }
        }
    }
}