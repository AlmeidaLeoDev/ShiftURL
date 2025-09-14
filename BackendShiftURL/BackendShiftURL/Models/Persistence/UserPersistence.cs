using Amazon.DynamoDBv2.DataModel;
using BackendShiftURL.Models.Shared;

namespace BackendShiftURL.Models.Persistence
{
    [DynamoDBTable("Users")]
    public class UserPersistence
    {
        [DynamoDBHashKey("UserId")]
        public required string UserId { get; set; }

        [DynamoDBProperty("Email")]
        public required string Email { get; set; }

        [DynamoDBProperty("PasswordHash")]
        public required string PasswordHash { get; set; }

        [DynamoDBProperty("Name")]
        public required string Name { get; set; }

        [DynamoDBProperty("EmailVerified")]
        public bool EmailVerified { get; set; } = false;

        [DynamoDBProperty("EmailVerificationToken")]
        public string? EmailVerificationToken { get; set; }

        [DynamoDBProperty("EmailVerificationExpires")]
        public long? EmailVerificationExpires { get; set; }

        [DynamoDBProperty("PasswordResetToken")]
        public string? PasswordResetToken { get; set; }

        [DynamoDBProperty("PasswordResetExpires")]
        public long? PasswordResetExpires { get; set; }

        [DynamoDBProperty("GoogleId")]
        public string? GoogleId { get; set; }

        [DynamoDBProperty("Avatar")]
        public string? Avatar { get; set; }

        [DynamoDBProperty("LastPasswordChange")]
        public long? LastPasswordChange { get; set; }

        [DynamoDBProperty("FailedLoginAttempts")]
        public int FailedLoginAttempts { get; set; } = 0;

        [DynamoDBProperty("AccountLockedUntil")]
        public long? AccountLockedUntil { get; set; }

        [DynamoDBProperty("CreatedAt")]
        public long CreatedAt { get; set; }

        [DynamoDBProperty("LastLoginAt")]
        public long? LastLoginAt { get; set; }

        [DynamoDBProperty("IsActive")]
        public bool IsActive { get; set; } = true;

        [DynamoDBProperty("Plan")]
        public UserPlan Plan { get; set; } = UserPlan.Free;

        [DynamoDBProperty("UrlsCreatedCount")]
        public int UrlsCreatedCount { get; set; } = 0;

        [DynamoDBProperty("MonthlyUrlLimit")]
        public int MonthlyUrlLimit { get; set; } = 100;

        [DynamoDBProperty("EmailLower")]
        [DynamoDBGlobalSecondaryIndexHashKey("Email-Index")]
        public string EmailLower { get; set; } = string.Empty;
    }
}
