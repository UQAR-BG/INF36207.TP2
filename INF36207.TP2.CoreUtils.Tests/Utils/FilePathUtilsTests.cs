using INF36207.TP2.Exceptions;
using INF36207.TP2.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INF36207.TP2.Core.Tests.Utils
{
    [TestClass]
    public class FilePathUtilsTests
    {
        [TestMethod]
        public void GivenInvalidChar_WhenIsCharsValid_ReturnFalse()
        {
            // Arrange
            string nameWithInvalidChars = "jadvghjawdvbw/hgasdvh.jpg";

            // Act

            // Assert
            Assert.ThrowsException<InvalidCharsInFilenameException>(() => FilePathUtils.ValidateIfCharsValid(nameWithInvalidChars));
        }
    }
}