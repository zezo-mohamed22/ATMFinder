using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ATMFinder.DAL.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Name).
               HasColumnType("varchar").
               HasMaxLength(50).IsRequired();
            builder.Property(u => u.Email).
                HasColumnType("varchar").
                HasMaxLength(100);
            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(u => u.ReputationScore)
                .HasDefaultValue(100);
            builder.Property(u => u.RefreshToken).HasMaxLength(250);
            builder.HasIndex(u => u.Email).IsUnique().HasDatabaseName("UX_Users_Emails");
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GetDate()");

        }
    }
}
