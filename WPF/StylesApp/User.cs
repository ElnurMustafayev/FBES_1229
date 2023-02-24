using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylesApp {
    public class User {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public User(string name, string surname, int age) {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public override string ToString() => $"{Name} {Surname}: {Age} years old";
    }
}
