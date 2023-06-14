using Microsoft.EntityFrameworkCore;
using RelationsApp.Entities.ManyToMany;
using RelationsApp.Entities.OneToMany;
using RelationsApp.Entities.OneToOne;

namespace RelationsApp;


public class MyDbContext : DbContext {
    // 1 - to - 1
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    // 1 - to - M
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    // M - to - M
    public DbSet<Chat> Chats { get; set; }
    public DbSet<User> Users { get; set; }

    // M - to - M (With relational Table)
    public DbSet<Product> Products { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ProductTag> ProductTags { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = $"Server=localhost;Database=MyAppDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductTag>()
            .HasKey(pt => new { pt.TagId, pt.ProductId });

        //modelBuilder.Entity<Post>()
        //    .HasMany<Comment>()
        //    .WithOne(comment => comment.Post)
        //    .HasForeignKey(comment => comment.PostId)
        //    .IsRequired();
    }
}