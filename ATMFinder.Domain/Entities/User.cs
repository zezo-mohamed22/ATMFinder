
namespace ATMFinder.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string Name { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public int ReputationScore { get; set; } = 100;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }

}
