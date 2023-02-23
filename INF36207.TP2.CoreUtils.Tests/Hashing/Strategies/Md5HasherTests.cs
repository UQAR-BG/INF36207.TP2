using INF36207.TP2.Enums;
using INF36207.TP2.Hashing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INF36207.TP2.Core.Tests.Hashing.Strategies
{
    [TestClass]
    public class Md5HasherTests
    {
        private readonly IHasher _hasher;

        public Md5HasherTests()
        {
            IHasherFactory hasherFactory = new HasherFactory();

            _hasher = hasherFactory.GetHasher(HashingStrategies.Md5);
        }

        [TestMethod]
        public void GivenInput_WhenComputeHash_ThenReturnMd5Hash()
        {
            // Arrange
            string input = "Hello World!";
            string expectedHash = "ED076287532E86365E841E92BFC50D8C";

            // Act
            var result = _hasher.ComputeHash(input);

            // Assert
            Assert.AreEqual(expectedHash, result);
        }

        [TestMethod]
        public void GivenEmptyInput_WhenComputeHash_ThenReturnEmptyString()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = _hasher.ComputeHash(input);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void GivenNullInput_WhenComputeHash_ThenReturnEmptyString()
        {
            // Arrange

            // Act
            var result = _hasher.ComputeHash(null);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}