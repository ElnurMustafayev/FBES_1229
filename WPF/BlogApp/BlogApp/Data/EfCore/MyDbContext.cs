namespace BlogApp.Data.EfCore;

using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        string connectionString = $"Server=localhost;Database=BlogApp;User Id=admin;Password=admin;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
    }
}