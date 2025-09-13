using Amazon.DynamoDBv2.DataModel;

namespace BackendShiftURL.Models.Persistence
{
    [DynamoDBTable("UrlMappings")]
    public class UrlMappingPersistence
    {
        [DynamoDBHashKey("ShortCode")]
        public required string ShortCode { get; set; }

        [DynamoDBProperty("OriginalUrl")]
        public required string OriginalUrl { get; set; }

        [DynamoDBProperty("CreatedAt")]
        public long CreatedAt { get; set; }

        [DynamoDBProperty("ExpiresAt")]
        public long? ExpiresAt { get; set; }

        [DynamoDBProperty("UserId")]
        [DynamoDBGlobalSecondaryIndexHashKey("UserId-CreatedAt-Index")]
        public required string UserId { get; set; }

        [DynamoDBProperty("CreatedByIp")]
        public required string CreatedByIp { get; set; }

        [DynamoDBProperty("ClickCount")]
        public long ClickCount { get; set; } = 0;

        [DynamoDBProperty("LastAccessedAt")]
        public long? LastAccessedAt { get; set; }

        [DynamoDBProperty("IsActive")]
        public bool IsActive { get; set; } = true;

        [DynamoDBProperty("Title")]
        public string? Title { get; set; }

        [DynamoDBProperty("Description")]
        public string? Description { get; set; }

        [DynamoDBGlobalSecondaryIndexRangeKey("UserId-CreatedAt-Index")]
        public long CreatedAtGSI => CreatedAt;

        [DynamoDBProperty("TTL")]
        public long? TTL => ExpiresAt;
    }
}
