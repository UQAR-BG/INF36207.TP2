using INF36207.TP2.Enums;
using INF36207.TP2.Hashing;
using INF36207.TP2.Hashing.Strategies;

namespace INF36207.TP2.Core.Tests.Hashing;

public class HasherFactoryTests
{
    private readonly IHasherFactory _factory;
    private HashingStrategies _hashingStrategy;

    public HasherFactoryTests()
    {
        _factory = new HasherFactory();
    }
    
    [Fact]
    public void GivenMd5HashingStrategy_WhenGetHasher_ThenReturnMd5Hasher()
    {
        // Act
        _hashingStrategy = HashingStrategies.Md5;

        // Arrange
        var result = _factory.GetHasher(_hashingStrategy);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Md5Hasher>();
    }
}