using INF36207.TP2.Files;
using INF36207.TP2.Files.Interfaces;

namespace INF36207.TP2.Core.Tests.Files;

public class PasswordDictionaryWriterTests
{
    private ITextWriter? _writer;
    private ITextReader? _reader;
    private const string FileName = "TextFileForWriteTests.txt";
    
    [Fact]
    public async Task WhenWriteLine_FileContainsNumberOfLines()
    {
        // Arrange
        _writer = new PasswordDictionaryWriter(FileName);

        // Act
        await _writer.WriteLine("hello");
        await _writer.WriteLine("world");
        _writer.Close();

        _reader = new PasswordDictionaryReader(FileName);
        var result = _reader.NumberOfLines;
        _reader.Close();

        // Assert
        result.Should().BePositive();
        result.Should().Be(2);
    }
    
    [Fact]
    public void GivenNoFile_WhenWriteLine_ThrowsException()
    {
        // Arrange
        _writer = new PasswordDictionaryWriter();

        // Act
        var result = async () => await _writer.WriteLine("Hello World");

        // Assert
        result.Should().ThrowAsync<FileNotFoundException>();
    }
}