using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATMFinder.DAL.Data.Configurations
{
    public class ATMReportConfiguration : IEntityTypeConfiguration<ATMReport>
    {
        public void Configure(EntityTypeBuilder<ATMReport> builder)
        {
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.Property(u => u.ExpiresAt)
                   .HasDefaultValueSql("DATEADD(HOUR, 4, GETDATE())");
            builder.HasOne(v => v.User)
                   .WithMany(u => u.ATMReports)
                   .HasForeignKey(v => v.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(v => v.ATM).WithMany(r => r.ATMReports).HasForeignKey(v => v.ATMId);
        }
    }
}
