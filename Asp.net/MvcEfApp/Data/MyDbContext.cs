namespace MvcEfApp.Data;

using Microsoft.EntityFrameworkCore;
using MvcEfApp.Models;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
}