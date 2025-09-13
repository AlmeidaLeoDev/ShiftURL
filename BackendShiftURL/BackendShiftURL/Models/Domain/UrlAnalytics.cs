namespace BackendShiftURL.Models.Domain
{
    public class UrlAnalytics
    {
        public required string ShortCode { get; set; }

        public required string AccessKey { get; set; }

        public required string AccessId { get; set; }
        public long AccessedAt { get; set; }
        public required string IpAddress { get; set; }
        public required string UserAgent { get; set; }
        public required string Referrer { get; set; }
        public required string Country { get; set; }
        public required string City { get; set; }

        public string? Device { get; set; }
        public string? Browser { get; set; }
        public string? OperatingSystem { get; set; }
    }
}
