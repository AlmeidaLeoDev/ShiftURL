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

        public static UrlAnalytics CreateNew(
            string shortCode,
            string accessId,
            string ipAddress,
            string userAgent,
            string referrer,
            string country,
            string city)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            return new UrlAnalytics
            {
                ShortCode = shortCode,
                AccessKey = $"{shortCode}#{now}#{accessId}",
                AccessId = accessId,
                AccessedAt = now,
                IpAddress = ipAddress,
                UserAgent = userAgent,
                Referrer = referrer,
                Country = country,
                City = city
            };
        }

        public static DateTime GetAccessDateTime(this UrlAnalytics analytics)
        {
            return DateTimeOffset.FromUnixTimeSeconds(analytics.AccessedAt).DateTime;
        }

        public static bool IsToday(this UrlAnalytics analytics)
        {
            var accessDate = analytics.GetAccessDateTime().Date;
            var today = DateTime.UtcNow.Date;
            return accessDate == today;
        }

        public static bool IsThisWeek(this UrlAnalytics analytics)
        {
            var accessDate = analytics.GetAccessDateTime();
            var startOfWeek = DateTime.UtcNow.AddDays(-(int)DateTime.UtcNow.DayOfWeek);
            return accessDate >= startOfWeek;
        }

        public static bool IsThisMonth(this UrlAnalytics analytics)
        {
            var accessDate = analytics.GetAccessDateTime();
            var now = DateTime.UtcNow;
            return accessDate.Year == now.Year && accessDate.Month == now.Month;
        }
    }
}
