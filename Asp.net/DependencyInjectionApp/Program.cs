using DependencyInjectionApp.Controllers;
using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services;
using DependencyInjectionApp.Services.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// create new object for each injection
//builder.Services.AddTransient<IUserRepository, UserTestRepository>();

// create new object for each request
//builder.Services.AddScoped<IUserRepository, UserTestRepository>(); 

// create one object for app
//builder.Services.AddSingleton<IUserRepository, UserTestRepository>(); 

// builder.Services.AddTransient<IUserRepository>(provider => {
//     System.Console.WriteLine("lambda for IUserRepository");
//     if(File.Exists("environment.txt") && File.ReadAllText("environment.txt") == "prod") {
//         return new UserFileRepository();
//     }
//     else {
//         return new UserTestRepository();
//     }
// });

// builder.Services.AddScoped<UserServiceBase>(provider => {
//     System.Console.WriteLine("lambda for UserServiceBase");
//     var repository = provider.GetRequiredService<IUserRepository>();

//     return new UserService(repository);
// });

builder.Services.AddScoped<UserServiceBase, UserService>(); 
builder.Services.AddScoped<IUserRepository>(provider => {
    switch (InjectionController.repoName)
    {
        case nameof(UserTestRepository):
            return new UserTestRepository();

        case nameof(UserFileRepository):
            return new UserFileRepository();
        
        default:
            throw new NotImplementedException();
    }
});



var app = builder.Build();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();