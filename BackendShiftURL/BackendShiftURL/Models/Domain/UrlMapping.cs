namespace BackendShiftURL.Models.Domain
{
    public class UrlMapping
    {
        public required string ShortCode { get; set; }

        public required string OriginalUrl { get; set; }
        public long CreatedAt { get; set; }
        public long? ExpiresAt { get; set; }
        public required string UserId { get; set; }
        public required string CreatedByIp { get; set; }
        public long ClickCount { get; set; } = 0;
        public long? LastAccessedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
