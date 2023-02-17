using INF36207.TP2.Enums;
using INF36207.TP2.Exceptions;
using INF36207.TP2.Files;
using INF36207.TP2.Files.Interfaces;

namespace INF36207.TP2.Core.Tests.Files;

public class FileHandlerFactoryTests
{
    private readonly IFileHandlerFactory _fileHandlerFactory;

    public FileHandlerFactoryTests()
    {
        _fileHandlerFactory = new FileHandlerFactory();
    }
    
    [Fact]
    public void GivenSupportedFileExtension_WhenGetFileHandler_ThenReturnFileHandler()
    {
        // Arrange
        string fileExtension = FileTypes.Text;

        // Act
        var result = _fileHandlerFactory.GetFileHandler(fileExtension);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeOfType<DictionaryFileHandler>();
    }
    
    [Fact]
    public void GivenUnsupportedFileExtension_WhenGetFileHandler_ThenThrowException()
    {
        // Arrange
        string fileExtension = "sdfhjsaebjqaehb";

        // Act

        // Assert
        Assert.Throws<UnsupportedFileTypeException>(() => _fileHandlerFactory.GetFileHandler(fileExtension));
    }
}