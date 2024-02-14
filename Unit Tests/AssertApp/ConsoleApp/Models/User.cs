namespace ConsoleApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public int Age { get; set; }

        public User(string username, int age)
        {
            this.Username = username;
            this.Age = age;
        }
    }
}