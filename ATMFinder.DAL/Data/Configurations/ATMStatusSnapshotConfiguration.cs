using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMFinder.DAL.Data.Configurations
{
    public class ATMStatusSnapshotConfiguration : IEntityTypeConfiguration<ATMStatusSnapshot>
    {
        public void Configure(EntityTypeBuilder<ATMStatusSnapshot> builder)
        {
            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.HasOne(s => s.ATM)
             .WithOne(a => a.ATMStatusSnapshot)
             .HasForeignKey<ATMStatusSnapshot>(s => s.ATMId)
             .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
