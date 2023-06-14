using BlogApp.Data.Configurations;
using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class BlogAppDbContext : DbContext
    {
        private const string connectionString = $"Server=localhost;Database=BlogAppDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
        public DbSet<User> Users { get; set; }

        private static FileStream fileStream = new FileStream("logs.txt", mode: FileMode.OpenOrCreate, access: FileAccess.Write);
        private static StreamWriter writer = new StreamWriter(fileStream);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);

            //writer.AutoFlush = true;
            //optionsBuilder.LogTo(writer.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());








            // // USER
            // // - Id
            // modelBuilder.Entity<User>()
            //     .Property(user => user.Id)
            //     .HasDefaultValueSql("NEWID()");

            // modelBuilder.Entity<User>()
            //     .HasKey(user => user.Id);

            // // - Name
            // modelBuilder.Entity<User>()
            //     .Property<string>(user => user.Name)
            //     .HasMaxLength(30)
            //     .HasColumnName("FirstName");

            // // - Surname
            // modelBuilder.Entity<User>()
            //     .Property<string>(user => user.Surname)
            //     .HasMaxLength(30)
            //     .HasColumnName("LastName");

            // // - Age
            // modelBuilder.Entity<User>()
            //     .Property<int?>(user => user.Age)
            //     .HasDefaultValue(0);

            // // - Constraints
            // modelBuilder.Entity<User>()
            // .ToTable(b => b.HasCheckConstraint("CK_Users_Age", "[Age] >= 0"));
        }
    }
}