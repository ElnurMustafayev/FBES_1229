namespace BlogApp.Entities;

using System;

public class Blog {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Content { get; set; }
    public int? AuthorId { get; set; }
    public User? Author { get; set; }

    public override string ToString() => $"{Title}: {Content}";
}