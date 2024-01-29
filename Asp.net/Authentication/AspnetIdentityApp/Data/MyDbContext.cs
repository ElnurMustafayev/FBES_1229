namespace AspnetIdentityApp.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
}