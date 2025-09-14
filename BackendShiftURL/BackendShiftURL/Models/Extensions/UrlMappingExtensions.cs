using BackendShiftURL.Models.Domain;
using BackendShiftURL.Models.Persistence;

namespace BackendShiftURL.Models.Extensions
{
    public static class UrlMappingExtensions
    {
        public static UrlMappingPersistence ToPersistence(this UrlMapping domain)
        {
            return new UrlMappingPersistence
            {
                ShortCode = domain.ShortCode,
                OriginalUrl = domain.OriginalUrl,
                CreatedAt = domain.CreatedAt,
                ExpiresAt = domain.ExpiresAt,
                UserId = domain.UserId,
                CreatedByIp = domain.CreatedByIp,
                ClickCount = domain.ClickCount,
                LastAccessedAt = domain.LastAccessedAt,
                IsActive = domain.IsActive,
                Title = domain.Title,
                Description = domain.Description
            };
        }

        public static UrlMapping ToDomain(this UrlMappingPersistence persistence)
        {
            return new UrlMapping
            {
                ShortCode = persistence.ShortCode,
                OriginalUrl = persistence.OriginalUrl,
                CreatedAt = persistence.CreatedAt,
                ExpiresAt = persistence.ExpiresAt,
                UserId = persistence.UserId,
                CreatedByIp = persistence.CreatedByIp,
                ClickCount = persistence.ClickCount,
                LastAccessedAt = persistence.LastAccessedAt,
                IsActive = persistence.IsActive,
                Title = persistence.Title,
                Description = persistence.Description
            };
        }

        public static IEnumerable<UrlMappingPersistence> ToPersistenceList(this IEnumerable<UrlMapping> domains)
        {
            return domains.Select(d => d.ToPersistence());
        }

        public static IEnumerable<UrlMapping> ToDomainList(this IEnumerable<UrlMappingPersistence> persistences)
        {
            return persistences.Select(p => p.ToDomain());
        }
    }
}
