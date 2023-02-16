using INF36207.TP2.Enums;
using INF36207.TP2.Hashing;

namespace INF36207.TP2.Core.Tests.Hashing.Strategies;

public class Md5HasherTests
{
    private readonly IHasher _hasher;

    public Md5HasherTests()
    {
        IHasherFactory hasherFactory = new HasherFactory();
        
        _hasher = hasherFactory.GetHasher(HashingStrategies.Md5);
    }
    
    [Fact]
    public void GivenInput_WhenComputeHash_ThenReturnMd5Hash()
    {
        // Arrange
        string input = "Hello World!";
        string expectedHash = "ed076287532e86365e841e92bfc50d8c";
        
        // Act
        var result = _hasher.ComputeHash(input);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedHash);
    }
    
    [Fact]
    public void GivenEmptyInput_WhenComputeHash_ThenReturnMd5Hash()
    {
        // Arrange
        string input = string.Empty;
        string expectedHash = "D41D8CD98F00B204E9800998ECF8427E";
        
        // Act
        var result = _hasher.ComputeHash(input);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<string>();
        result.Should().BeEquivalentTo(expectedHash);
    }
}