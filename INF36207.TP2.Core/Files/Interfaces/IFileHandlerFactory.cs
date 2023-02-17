namespace INF36207.TP2.Files.Interfaces;

public interface IFileHandlerFactory
{
    IFileHandler GetFileHandler(string fileExtension);
}