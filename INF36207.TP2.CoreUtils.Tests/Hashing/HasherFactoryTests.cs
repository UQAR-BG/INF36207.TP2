using INF36207.TP2.Enums;
using INF36207.TP2.Hashing;
using INF36207.TP2.Hashing.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INF36207.TP2.Core.Tests.Hashing
{
    [TestClass]
    public class HasherFactoryTests
    {
        private readonly IHasherFactory _factory;
        private HashingStrategies _hashingStrategy;

        public HasherFactoryTests()
        {
            _factory = new HasherFactory();
        }

        [TestMethod]
        public void GivenMd5HashingStrategy_WhenGetHasher_ThenReturnMd5Hasher()
        {
            // Act
            _hashingStrategy = HashingStrategies.Md5;

            // Arrange
            var result = _factory.GetHasher(_hashingStrategy);

            // Assert
            Assert.IsInstanceOfType(result, typeof(Md5Hasher));
        }
    }
}