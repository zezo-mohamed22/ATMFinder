using ATMFinder.Domain.Enums;

namespace ATMFinder.Domain.Entities
{
    public class ATMReport
    {
        public int Id { get; set; }
        public int ATMId { get; set; }
        public int UserId { get; set; }
        public ATMStatus Status { get; set; }
        public CashLevel CashLevel { get; set; }   // Empty, Low, Available
        public CrowdLevel CrowdLevel { get; set; } // None, Low, Medium, High
        public string? Note { get; set; }
        public DateTime ExpiresAt { get; set; }    // Set to Now + 4 hours on create
        public bool IsExpired { get; set; }
        public DateTime CreatedAt { get; set; }
        public ATM ATM { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<ReportVote> Votes { get; set; } = new List<ReportVote>();

    }

}
