using System.Collections;

namespace IteratorApp {
    public class StudentGroup : IEnumerable<Student> {
        public string Name { get; set; }
        IEnumerable<Student> Students { get; set; }

        public IEnumerator<Student> iterator;

        public StudentGroup(string name, IEnumerable<Student> students, IEnumerator<Student> iterator) {
            this.Name = name;
            this.Students = students;
            this.iterator = iterator;
        }

        public IEnumerator<Student> GetEnumerator() {
            return this.iterator;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.iterator;
        }
    }
}
