using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATMFinder.DAL.Data.Configurations
{
    public class ATMConfigurations :IEntityTypeConfiguration<ATM>
    {
        public void Configure(EntityTypeBuilder<ATM> builder)
        {
            builder.Property(u => u.Name).
             HasColumnType("varchar").
             HasMaxLength(50).IsRequired();
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.Property(u => u.UpdatedAt).HasDefaultValueSql("GetDate()");
            builder.Property(u => u.Latitude).HasPrecision(18, 6);
            builder.Property(u => u.Longitude).HasPrecision(18, 6);
            builder.Property(u => u.Address)
                .HasColumnType("nvarchar")
                .IsRequired().HasMaxLength(200);
            builder.HasOne(a => a.Bank).WithMany(a => a.ATMs)
                .HasForeignKey(a => a.BankId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
