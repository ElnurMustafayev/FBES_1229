﻿namespace UsersStorageApp;

public class User {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public User() {
        this.Id = Guid.NewGuid();
    }

    public override string ToString() => $"{Id}: {Name} {Surname}";
}