using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // USER
            // - Id
            builder
                .Property(user => user.Id)
                .HasColumnName("UID")
                .HasDefaultValueSql("NEWID()");

            builder
                .HasKey(user => user.Id);

            // - Name
            builder
                .Property<string>(user => user.Name)
                .HasMaxLength(30)
                .HasColumnName("Name");

            // - Surname
            builder
                .Property<string>(user => user.Surname)
                .HasMaxLength(30)
                .HasColumnName("Surname");

            // - Age
            builder
                .Property<int?>(user => user.Age)
                .HasDefaultValue(0);

            // - Constraints
            builder
                .ToTable(b => b.HasCheckConstraint("CK_Users_Age", "[Age] >= 1"));
        }
    }
}