using ATMFinder.Domain.Enums;

namespace ATMFinder.Domain.Entities
{
    public class ATMStatusSnapshot
    {
        public int Id { get; set; }
        public ATM ATM { get; set; } = default!;
        public int ATMId { get; set; }
        public ATMStatus ATMStatus { get;set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Confidence { get; set; } 



    }
}
