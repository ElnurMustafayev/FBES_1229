using MyClassLib.Repositories;
using MyClassLib.Repositories.Base;

public class Program {
    private static async Task Main() {
        // User user = new User() {
        //     Login = "Elnur",
        //     Password = "Test12345",
        // };

        // Console.WriteLine(user);



        //Console.WriteLine(File.ReadAllText("Assets/test.json"));



        IUserRepository repository = new UserDapperRepository();
        var user = await repository.GetUserByLoginAsync("glacheze1c@hatena.ne.jp");

        Console.WriteLine(user);
    }
}