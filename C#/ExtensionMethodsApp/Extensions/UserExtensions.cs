namespace ExtensionMethodsApp.Extensions;

public static class UserExtensions
{
    public static void Say<T>(this User user, T data) {
        Console.WriteLine($"{user.Name}: {data}");
    }
    public static void Say(this User user, string data) {
        Console.WriteLine($"{user.Name}: \"{data}\"");
    }

    public static int Say(this User user, params string[] messages) {
        foreach (var message in messages) {
            user.Say(message);
        }

        return messages.Count();
    }
}