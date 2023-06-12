namespace RelationsApp.Entities.ManyToMany;

public class Chat {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<User> Users { get; set; }

    public Chat() {

    }

    public Chat(string name) {
        this.Name = name;
    }
}