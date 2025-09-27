using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Moq;

namespace BackendShiftURL.Tests;

public class DynamoDbTests
{
    private readonly Mock<IAmazonDynamoDB> _mockDynamoDb;
    private readonly DynamoDbTests _dynamoDbTests;

    public DynamoDbTests(Mock<IAmazonDynamoDB> mockDynamoDb, DynamoDbTests dynamoDbTests)
    {
        _mockDynamoDb = mockDynamoDb;
        _dynamoDbTests = dynamoDbTests;
    }

    [Fact]
    public void Test1()
    {

    }
}
