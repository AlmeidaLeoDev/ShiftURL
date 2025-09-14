using BackendShiftURL.Models.Domain;
using BackendShiftURL.Models.Persistence;

namespace BackendShiftURL.Models.Extensions
{
    public static class UserExtensions
    {
        public static UserPersistence ToPersistence(this User domain)
        {
            return new UserPersistence
            {
                UserId = domain.UserId,
                Email = domain.Email,
                PasswordHash = domain.PasswordHash,
                Name = domain.Name,
                EmailVerified = domain.EmailVerified,
                EmailVerificationToken = domain.EmailVerificationToken,
                EmailVerificationExpires = domain.EmailVerificationExpires,
                PasswordResetToken = domain.PasswordResetToken,
                PasswordResetExpires = domain.PasswordResetExpires,
                GoogleId = domain.GoogleId,
                Avatar = domain.Avatar,
                LastPasswordChange = domain.LastPasswordChange,
                FailedLoginAttempts = domain.FailedLoginAttempts,
                AccountLockedUntil = domain.AccountLockedUntil,
                CreatedAt = domain.CreatedAt,
                LastLoginAt = domain.LastLoginAt,
                IsActive = domain.IsActive,
                Plan = domain.Plan,
                UrlsCreatedCount = domain.UrlsCreatedCount,
                MonthlyUrlLimit = domain.MonthlyUrlLimit,
                EmailLower = domain.EmailLower
            };
        }

        public static User ToDomain(this UserPersistence persistence)
        {
            return new User
            {
                UserId = persistence.UserId,
                Email = persistence.Email,
                PasswordHash = persistence.PasswordHash,
                Name = persistence.Name,
                EmailVerified = persistence.EmailVerified,
                EmailVerificationToken = persistence.EmailVerificationToken,
                EmailVerificationExpires = persistence.EmailVerificationExpires,
                PasswordResetToken = persistence.PasswordResetToken,
                PasswordResetExpires = persistence.PasswordResetExpires,
                GoogleId = persistence.GoogleId,
                Avatar = persistence.Avatar,
                LastPasswordChange = persistence.LastPasswordChange,
                FailedLoginAttempts = persistence.FailedLoginAttempts,
                AccountLockedUntil = persistence.AccountLockedUntil,
                CreatedAt = persistence.CreatedAt,
                LastLoginAt = persistence.LastLoginAt,
                IsActive = persistence.IsActive,
                Plan = persistence.Plan,
                UrlsCreatedCount = persistence.UrlsCreatedCount,
                MonthlyUrlLimit = persistence.MonthlyUrlLimit,
                EmailLower = persistence.EmailLower
            };
        }

        public static IEnumerable<UserPersistence> ToPersistenceList(this IEnumerable<User> domains)
        {
            return domains.Select(d => d.ToPersistence());
        }

        public static IEnumerable<User> ToDomainList(this IEnumerable<UserPersistence> persistences)
        {
            return persistences.Select(p => p.ToDomain());
        }
    }
}
