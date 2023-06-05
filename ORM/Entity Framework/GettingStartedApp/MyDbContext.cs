// 1. dotnet tool install --global dotnet-ef
// 2. create .net project
// 3. dotnet add package Microsoft.EntityFrameworkCore
// 4. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// 5. create DbContext class
// 6. connect to DB in DbContext.OnConfiguring
// 7. dotnet add package Microsoft.EntityFrameworkCore.Design
// 8. dotnet ef migrations add "Migration Title"
// 9. dotnet ef database update
// 10. dotnet run

namespace GettingStartedApp;

using GettingStartedApp.Entities;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = $"Server=localhost;Database=GettingStarted;User Id=admin;Password=admin;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}