namespace INF36207.TP2.Files.Interfaces
{
    public interface ITextReader : IFileHandler
    {
        int NumberOfLines { get; }
        int GetNumberOfLines();
        string ReadLine();
    }
}