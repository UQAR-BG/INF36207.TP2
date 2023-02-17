using INF36207.TP2.Exceptions;
using INF36207.TP2.Utils;

namespace INF36207.TP2.Core.Tests.Utils;

public class FilePathUtilsTests
{
    [Fact]
    public void GivenInvalidChar_WhenIsCharsValid_ReturnFalse()
    {
        // Arrange
        string nameWithInvalidChars = "jadvghjawdvbw/hgasdvh.jpg";

        // Act

        // Assert
        Assert.Throws<InvalidCharsInFilenameException>(() => FilePathUtils.ValidateIfCharsValid(nameWithInvalidChars));
    }
    
    [Fact]
    public void GivenValidName_WhenIsCharsValid_ReturnTrue()
    {
        // Arrange
        string nameWithInvalidChars = "jadvghjawdvbw.jpg";

        // Act
        var result = () => FilePathUtils.ValidateIfCharsValid(nameWithInvalidChars);

        // Assert
        result.Should().NotThrow<Exception>();
    }
}