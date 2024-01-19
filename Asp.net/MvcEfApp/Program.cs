using Microsoft.EntityFrameworkCore;
using MvcEfApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(dbContextOptionsBuilder => {
    var connectionString = builder.Configuration.GetConnectionString("TestEfDb");
    dbContextOptionsBuilder.UseSqlServer(connectionString);
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
