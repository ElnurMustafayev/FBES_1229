namespace JsonApp;

enum GENDERS : int {
    Male, Female, Other, Unknown,
}

class User {
    public string Name { get; set; }
    public string Surname { get; set; }
    public uint Age { get; set; }
    public GENDERS Gender { get; set; }
}