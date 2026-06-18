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
            
        }
    }
}
