using App.Core.Repositories;
using App.Core.Services;
using App.Infrastructure.Repositories;
using App.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserFakeRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
