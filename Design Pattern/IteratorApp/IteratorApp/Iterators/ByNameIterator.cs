using System.Collections;

namespace IteratorApp.Iterators {
    public class ByNameIterator : IEnumerator<Student> {
        private IEnumerable<Student> students;
        int index = 0;

        public Student Current {
            get {
                var list = this.students.ToList();
                list.Sort((st1, st2) => st1.Name.CompareTo(st2.Name));

                return list[this.index++];
            }
        }

        object IEnumerator.Current => this.Current;

        public ByNameIterator(IEnumerable<Student> students) {
            this.students = students;
        }

        public void Dispose() { }

        public bool MoveNext() {
            bool canMove = this.index < this.students.Count();

            if (!canMove)
                this.Reset();

            return canMove;
        }

        public void Reset() {
            this.index = 0;
        }
    }
}
