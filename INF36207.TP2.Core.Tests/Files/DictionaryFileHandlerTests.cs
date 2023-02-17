using INF36207.TP2.Files;

namespace INF36207.TP2.Core.Tests.Files;

public class DictionaryFileHandlerTests
{
    [Fact]
    public void Test()
    {
        string fileName = "/home/bastiengoulet/Documents/test.txt";
        DictionaryFileHandler handler = new DictionaryFileHandler(fileName);

        string? firstLine = handler.ReadLine();
        string? secondLine = handler.ReadLine();
        string? thirdLine = handler.ReadLine();

        firstLine.Should().BeEquivalentTo("hello");
        secondLine.Should().BeEquivalentTo("world");
        thirdLine.Should().BeNull();
        
        handler.CloseFile();
    }
}