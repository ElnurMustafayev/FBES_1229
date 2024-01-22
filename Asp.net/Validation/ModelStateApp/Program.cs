using AkhshamBazari.Repositories;
using AkhshamBazari.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using ModelStateApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddDbContext<MyDbContext>(options => {
    const string connectionStringKey = "MyTestDb";
    var connectionString = builder.Configuration.GetConnectionString(connectionStringKey);

    if(string.IsNullOrWhiteSpace(connectionString)) {
        #pragma warning disable CA2208
        throw new ArgumentNullException(paramName: nameof(connectionString),
                                        message: $"EF Connection strign is empty. Key '{connectionStringKey}' not found!");
        #pragma warning restore 
    }

    options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
