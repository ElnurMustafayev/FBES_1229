using ConfigurationApp.Models;
using ConfigurationApp.Repositories;
using ConfigurationApp.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var frontColor = builder.Configuration
    .GetSection("Palette")
    .GetSection("front")
    .Get<string>();

System.Console.WriteLine(frontColor);   // red



var palette = builder.Configuration
    .GetSection("Palette")
    .Get<Palette>();

System.Console.WriteLine(palette?.background); // white

// builder.Services.AddSingleton<Palette>(palette);
// builder.Services.AddScoped<Palette>((provider) => {
//     return builder.Configuration
//         .GetSection("Palette")
//         .Get<Palette>();
// });


var paletteSection = builder.Configuration
    .GetSection("Palette");

builder.Services.Configure<Palette>(paletteSection);

// builder.Services.Configure<Palette>(paletteSection, 
//     configureBinder: (options) => {
//     });

builder.Services.AddScoped<IUserRepository>(provider => {
    const string connectionStringFileName = "UsersDb";
    string? connectionString = builder.Configuration.GetConnectionString(connectionStringFileName);

    if(string.IsNullOrWhiteSpace(connectionString)) {
        throw new Exception($"field {connectionStringFileName} not found in setting.json!");
    }
    
    return new UserSqlRepository(connectionString);
});



var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
