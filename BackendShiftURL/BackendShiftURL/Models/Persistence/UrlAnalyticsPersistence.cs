using Amazon.DynamoDBv2.DataModel;

namespace BackendShiftURL.Models.Persistence
{
    [DynamoDBTable("UrlAnalytics")]
    public class UrlAnalyticsPersistence
    {
        [DynamoDBHashKey("ShortCode")]
        public required string ShortCode { get; set; }

        [DynamoDBRangeKey("AccessKey")]
        public required string AccessKey { get; set; }

        [DynamoDBProperty("AccessId")]
        public required string AccessId { get; set; }

        [DynamoDBProperty("AccessedAt")]
        public long AccessedAt { get; set; }

        [DynamoDBProperty("IpAddress")]
        public required string IpAddress { get; set; }

        [DynamoDBProperty("UserAgent")]
        public required string UserAgent { get; set; }

        [DynamoDBProperty("Referrer")]
        public required string Referrer { get; set; }

        [DynamoDBProperty("Country")]
        public required string Country { get; set; }

        [DynamoDBProperty("City")]
        public required string City { get; set; }

        [DynamoDBProperty("Device")]
        public string? Device { get; set; }

        [DynamoDBProperty("Browser")]
        public string? Browser { get; set; }

        [DynamoDBProperty("OperatingSystem")]
        public string? OperatingSystem { get; set; }
    }
}
