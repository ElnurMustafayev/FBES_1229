#pragma warning disable CS8618

using JwtTokensApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtTokensApp.Data;

public class IdentityDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }
}