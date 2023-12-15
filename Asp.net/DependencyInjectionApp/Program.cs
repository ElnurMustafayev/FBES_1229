using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services;
using DependencyInjectionApp.Services.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IUserRepository, UserTestRepository>();
builder.Services.AddSingleton<UserServiceBase, UserService>();

var app = builder.Build();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();