namespace AspnetIdentityApp.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : IdentityDbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
}