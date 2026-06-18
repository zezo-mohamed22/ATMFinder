using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATMFinder.DAL.Data.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.Property(u => u.Name).
               HasColumnType("nvarchar").
               HasMaxLength(50).IsRequired();
            builder.Property(u => u.Code)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");
            
        }
    }
}
