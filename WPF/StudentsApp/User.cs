using System;

namespace StudentsApp;

public enum Gender
{
    Male, Female
}

public class User {
    public string Id { get; set; }
    public string Firstname { get; set; }
    public string Secondname { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public bool IsMarried { get; set; }
    public string BirthDate { get; set; }
    public string Avatar { get; set; }
}
