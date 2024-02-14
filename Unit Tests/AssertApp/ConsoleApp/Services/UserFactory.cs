namespace ConsoleApp.Services;

using ConsoleApp.Models;

public class UserFactory {
    public static User Create(string username, int age) {
        if(username is null) {
            throw new ArgumentNullException(nameof(username));
        }

        if(age < 0) {
            throw new ArgumentOutOfRangeException(
                paramName: nameof(age),
                actualValue: age,
                message: $"Age can not be less than 0!"
            );
        }

        username = username.Trim();

        return new User(username, age);
    }
}