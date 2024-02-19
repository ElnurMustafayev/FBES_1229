using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static User Create() => new() {
            Id = 100,
            Name = "Fake",
            Age = 30,
        };
    }
}