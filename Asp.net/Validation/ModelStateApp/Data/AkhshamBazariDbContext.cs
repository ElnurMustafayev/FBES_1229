#pragma warning disable CS8618

namespace ModelStateApp.Data;

using ModelStateApp.Models;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {
    public DbSet<Product> Products { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}
}