using BackendShiftURL.Models.Domain;
using BackendShiftURL.Models.Persistence;

namespace BackendShiftURL.Models.Extensions
{
    public static class UrlAnalyticsExtensions
    {
        public static UrlAnalyticsPersistence ToPersistence(this UrlAnalytics domain)
        {
            return new UrlAnalyticsPersistence
            {
                ShortCode = domain.ShortCode,
                AccessKey = domain.AccessKey,
                AccessId = domain.AccessId,
                AccessedAt = domain.AccessedAt,
                IpAddress = domain.IpAddress,
                UserAgent = domain.UserAgent,
                Referrer = domain.Referrer,
                Country = domain.Country,
                City = domain.City,
                Device = domain.Device,
                Browser = domain.Browser,
                OperatingSystem = domain.OperatingSystem
            };
        }

        public static UrlAnalytics ToDomain(this UrlAnalyticsPersistence persistence)
        {
            return new UrlAnalytics
            {
                ShortCode = persistence.ShortCode,
                AccessKey = persistence.AccessKey,
                AccessId = persistence.AccessId,
                AccessedAt = persistence.AccessedAt,
                IpAddress = persistence.IpAddress,
                UserAgent = persistence.UserAgent,
                Referrer = persistence.Referrer,
                Country = persistence.Country,
                City = persistence.City,
                Device = persistence.Device,
                Browser = persistence.Browser,
                OperatingSystem = persistence.OperatingSystem
            };
        }

        public static IEnumerable<UrlAnalyticsPersistence> ToPersistenceList(this IEnumerable<UrlAnalytics> domains)
        {
            return domains.Select(d => d.ToPersistence());
        }

        public static IEnumerable<UrlAnalytics> ToDomainList(this IEnumerable<UrlAnalyticsPersistence> persistences)
        {
            return persistences.Select(p => p.ToDomain());
        }
    }
}
