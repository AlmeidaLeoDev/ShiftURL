using BackendShiftURL.Models.Shared;

namespace BackendShiftURL.Models.Domain
{
    public class User
    {
        public required string UserId { get; set; }

        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Name { get; set; }

        public bool EmailVerified { get; set; } = false;
        public string? EmailVerificationToken { get; set; }
        public long? EmailVerificationExpires { get; set; }

        public string? PasswordResetToken { get; set; }
        public long? PasswordResetExpires { get; set; }

        public string? GoogleId { get; set; }
        public string? Avatar { get; set; }

        public long? LastPasswordChange { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;
        public long? AccountLockedUntil { get; set; }

        public long CreatedAt { get; set; }
        public long? LastLoginAt { get; set; }
        public bool IsActive { get; set; } = true;
        public UserPlan Plan { get; set; } = UserPlan.Free;
        public int UrlsCreatedCount { get; set; } = 0;
        public int MonthlyUrlLimit { get; set; } = 100;

        public string EmailLower { get; set; } = string.Empty;
    }
}
