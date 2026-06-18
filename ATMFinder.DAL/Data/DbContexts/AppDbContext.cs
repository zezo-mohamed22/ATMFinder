using ATMFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ATMFinder.DAL.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ATMReport> ATMReports { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<ATM> Atms { get; set; }
        public DbSet<ReportVote> ReportVotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
