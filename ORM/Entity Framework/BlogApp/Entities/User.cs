using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Entities
{
    //[Table("Users")]
    public class User
    {
        public User(string name, string surname, int? age) {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public User() {

        }

        // [Key]
        // [Column(Order = 1)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        // [MaxLength(50)]
        // [Column("user_name", Order = 2)]
        public string Name { get; set; }

        // [MaxLength(50)]
        // [Column("user_surname", TypeName = "nvarchar(100)", Order = 3)]
        public string Surname { get; set; }

        public int? Age { get; set; }

        public override string ToString() => $"[{Id}] {Name} {Surname}: {Age} years old";
    }
}