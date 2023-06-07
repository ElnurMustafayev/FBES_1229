using BlogApp.Data;
using BlogApp.Entities;

BlogAppDbContext context = new BlogAppDbContext();

if (false) {
    var result = context.Users.Where(user => user.Age > 20)
        .Select(user => user.Name)
        .ToList();

    foreach (var user in result) {
        Console.WriteLine(user);
    }
}


if (false) {
    var users = context.Users.Where(user => user.Age > 20);
    var names = users.Select(user => user.Name);

    var result = names.ToList();

    foreach (var user in result) {
        Console.WriteLine(user);
    }
}








if(false) {
    for (int i = 0; i < 1000; i++) {
        context.Users.Add(new User(Guid.NewGuid().ToString()[..25], Guid.NewGuid().ToString()[..25], new Random().Next(10, 100)));
    }

    context.SaveChanges();
}

if(false) {
    context.Users.Add(new User("Ann", "Brown", 18));
    context.Users.Add(new User("Kate", "White", 23));
    context.Users.Add(new User("John", "Grey", 30));

    var newUser = new User("Test", "Test", 5);
    var result = context.Users.Add(newUser);

    Console.WriteLine(newUser.Id);
    Console.WriteLine(result.Entity.Id);
    context.SaveChanges();
    Console.WriteLine(newUser.Id);
    Console.WriteLine(result.Entity.Id);
}