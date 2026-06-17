namespace ATMFinder.Domain.Entities
{
    public class ReportVote
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public bool IsUpvote { get; set; }
        public DateTime CreatedAt { get; set; }
        public ATMReport Report { get; set; } = null!;
        public User User { get; set; } = null!;

    }

}
