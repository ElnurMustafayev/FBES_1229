using System.Runtime;

namespace SignletonApp;

public class User {
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool IsAdult => this.Age >= SettingsSingleton.GetInstance().Settings.AdultYear;

    public User(string name, string surname, int age) {
        var settings = SettingsSingleton.GetInstance().Settings;

        if(name.Length < settings.UsernameMaxLength) {
            Name = name;
        }
        if (surname.Length < settings.SurnameMaxLength) {
            Surname = surname;
        }

        Age = age;
    }
}