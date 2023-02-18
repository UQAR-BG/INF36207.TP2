using INF36207.TP2.Files;
using INF36207.TP2.Files.Interfaces;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Core.Tests.Files;

public class PasswordDictionaryReaderTests
{
    private ITextReader? _reader;
    private const string FileName = "TextFileForTests.txt";
    private const string EmptyFileName = "EmptyFileForTests.txt";

    [Fact]
    public void GivenNoFile_WhenGetNumberOfLines_ReturnZero()
    {
        // Arrange
        _reader = new PasswordDictionaryReader();

        // Act
        var result = _reader.GetNumberOfLines();

        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void GivenNoFile_WhenNumberOfLines_ReturnZero()
    {
        // Arrange
        _reader = new PasswordDictionaryReader();

        // Act
        var result = _reader.NumberOfLines;

        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void GivenTextFile_WhenGetNumberOfLines_ReturnNumberOfLines()
    {
        // Arrange
        _reader = new PasswordDictionaryReader(FileName);
        int expectedNbrOfLines = 2;

        // Act
        var result = _reader.GetNumberOfLines();

        // Assert
        result.Should().BePositive();
        result.Should().Be(expectedNbrOfLines);
        
        _reader.Close();
    }
    
    [Fact]
    public void GivenTextFile_WhenNumberOfLines_ReturnNumberOfLines()
    {
        // Arrange
        _reader = new PasswordDictionaryReader(FileName);
        int expectedNbrOfLines = 2;

        // Act
        var result = _reader.NumberOfLines;

        // Assert
        result.Should().BePositive();
        result.Should().Be(expectedNbrOfLines);
        
        _reader.Close();
    }
    
    [Fact]
    public void GivenNonEmptyTextFile_WhenReadLine_ReturnStringLine()
    {
        // Arrange
        _reader = new PasswordDictionaryReader(FileName);

        // Act
        string? firstLine = _reader.ReadLine();
        string? secondLine = _reader.ReadLine();
        string? thirdLine = _reader.ReadLine();

        // Assert
        firstLine.Should().BeEquivalentTo("hello");
        secondLine.Should().BeEquivalentTo("world");
        thirdLine.Should().BeNull();
        
        _reader.Close();
    }
    
    [Fact]
    public void GivenNoFile_WhenReadLine_ThrowsException()
    {
        // Arrange
        _reader = new PasswordDictionaryReader();

        // Act
        var result = () => _reader.ReadLine();

        // Assert
        result.Should().Throw<FileNotFoundException>();
        
        _reader.Close();
    }
    
    [Fact]
    public void GivenEmptyTextFile_WhenReadLine_ReturnNull()
    {
        // Arrange
        _reader = new PasswordDictionaryReader(EmptyFileName);

        // Act
        string? line = _reader.ReadLine();

        // Assert
        line.Should().BeNull();
        
        _reader.Close();
    }
}