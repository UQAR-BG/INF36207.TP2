using INF36207.TP2.Enums;
using INF36207.TP2.Exceptions;
using INF36207.TP2.Files.Interfaces;

namespace INF36207.TP2.Files;

public class FileHandlerFactory : IFileHandlerFactory
{
    private IFileHandler? _fileHandler;
    
    public IFileHandler GetFileHandler(string fileExtension)
    {
        _fileHandler = fileExtension switch
        {
            FileTypes.Text => new DictionaryFileHandler(),
            _ => throw new UnsupportedFileTypeException($"File with extension: {fileExtension} not supported.")
        };

        return _fileHandler;
    }
}