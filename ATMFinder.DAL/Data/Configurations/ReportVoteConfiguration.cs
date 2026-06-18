using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATMFinder.DAL.Data.Configurations
{
    public class ReportVoteConfiguration : IEntityTypeConfiguration<ReportVote>
    {
        public void Configure(EntityTypeBuilder<ReportVote> builder)
        {
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.HasOne(v => v.User)
                   .WithMany(u => u.ReportVotes)
                   .HasForeignKey(v => v.UserId)
                   .OnDelete(DeleteBehavior.Restrict); builder.HasOne(v => v.Report).WithMany(r => r.Votes).HasForeignKey(v => v.ReportId);
            builder.HasIndex(v => new { v.UserId, v.ReportId }).IsUnique();
        }
    }
}
