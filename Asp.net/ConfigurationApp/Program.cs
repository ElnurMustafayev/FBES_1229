using ConfigurationApp.Models;
using ConfigurationApp.Repositories;
using ConfigurationApp.Repositories.Base;
using Microsoft.Extensions.Configuration.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

if(false) {
    var frontColor = builder.Configuration
        .GetSection("Palette")
        .GetSection("foreground")
        .Get<string>();

    System.Console.WriteLine(frontColor);   // red



    var palette = builder.Configuration
        .GetSection("Palette")
        .Get<Palette>();

    System.Console.WriteLine(palette?.background); // white
}


// builder.Services.AddSingleton<Palette>(palette);
// builder.Services.AddScoped<Palette>((provider) => {
//     return builder.Configuration
//         .GetSection("Palette")
//         .Get<Palette>();
// });


var paletteSection = builder.Configuration
    .GetSection("Palette");

builder.Services.Configure<Palette>(paletteSection);


// const string mySettingFileName = "test.json";
// builder.Configuration.AddJsonFile(mySettingFileName);
// var login = builder.Configuration
//     .GetSection("MyTestOptions")
//     .GetSection("Login")
//     .Get<string>();

// System.Console.WriteLine($"Login: {login}");

// // get all sources
// foreach (var item in builder.Configuration.Sources)
// {
//     if(item is JsonConfigurationSource jsonConfigurationSource) {
//         System.Console.WriteLine(jsonConfigurationSource.Path);
//     }
// }

/*
// remove all json sources except {mySettingFileName}
var jsonSourcesToDelete = builder.Configuration.Sources
    .Where(source => {
        if(source is JsonConfigurationSource jsonConfigurationSource) {
            if(jsonConfigurationSource.Path == null) 
                return true;

            if(jsonConfigurationSource.Path.EndsWith(mySettingFileName))
                return false;
            return true;
        }
        return false;
    });

System.Console.WriteLine(jsonSourcesToDelete.Count());

for (int i = 0; i < jsonSourcesToDelete.Count(); i++)
{
    System.Console.WriteLine($"ITERATOIN {i}");
    builder.Configuration.Sources.Remove(jsonSourcesToDelete.ElementAt(i));
}

foreach (var item in builder.Configuration.Sources) {
    if(item is JsonConfigurationSource jsonConfigurationSource) {
        System.Console.WriteLine(jsonConfigurationSource.Path);
    }
}
*/



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
