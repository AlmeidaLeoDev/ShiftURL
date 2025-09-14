namespace BackendShiftURL.Models
{
    public class User
    {
        // Partition Key
        public required string UserId { get; set; }

        // Common fields
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Name { get; set; }

        // Authentication
        public bool EmailVerified { get; set; } = false;
        public string? EmailVerificationToken { get; set; }
        public long? EmailVerificationExpires { get; set; }

        // Reset
        public string? PasswordResetToken { get; set; }
        public long? PasswordResetExpires { get; set; }

        // Goolge OAuth
        public string? GoogleId { get; set; }
        public string? Avatar { get; set; }

        // Security
        public long? LastPasswordChange { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public long? AccountLockedUntil { get; set; }

        // Timestamp
        public long CreatedAt { get; set; }
        public long? LastLoginAt { get; set; }
        public bool IsActive { get; set; } = true;
        public UserPlan Plan { get; set; } = UserPlan.Free;
        public int UrlsCreatedCount { get; set; } = 0;
        public int MonthlyUrlLimit { get; set; } = 100;

        // Queries
        public string EmailLower { get; set; } = string.Empty;
    }

    public enum UserPlan
    {
        Free,
        Premium,
        Enterprise
    }
}
