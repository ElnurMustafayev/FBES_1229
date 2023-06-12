namespace RelationsApp.Entities.ManyToMany;

public class User {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Chat> Chats { get; set; }

    public User() {

    }

    public User(string name) {
        this.Name = name;
    }

    public override string ToString() => $"{Id}. {Name}";
}