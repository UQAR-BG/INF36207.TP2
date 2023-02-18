namespace INF36207.TP2.Files.Interfaces;

public interface ITextWriter : IFileHandler
{
    Task Write(IEnumerable<string> content);
    Task WriteLine(string line);
}