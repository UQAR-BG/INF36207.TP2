using System.Text;
using INF36207.TP2.Enums;
using INF36207.TP2.Files.Interfaces;
using File = INF36207.TP2.Files.Entities.File;

namespace INF36207.TP2.Files;

public class DictionaryFileHandler : IFileHandler
{
    private static readonly string Type = FileTypes.Text;
    private const int BufferSize = 128;

    private FileStream? _fileStream;
    private StreamReader? _streamReader;
    private File? _file;

    public DictionaryFileHandler()
    {
        
    }
    
    public DictionaryFileHandler(string fileName)
    {
        OpenFile(fileName);
    }

    public void OpenFile(string fileName)
    {
        _file = new File(fileName);
        OpenStreamReaderIfNeeded(_file);
    }
    
    public void CloseFile()
    {
        _streamReader?.Close();
        _fileStream?.Close();
    }

    public string? ReadLine()
    {
        if (!CanRead())
            return string.Empty;

        OpenStreamReaderIfNeeded(_file!);
        return _streamReader!.ReadLine();
    }

    private bool CanRead()
    {
        return _file != null;
    }

    private void OpenStreamReaderIfNeeded(File file)
    {
        _fileStream ??= System.IO.File.OpenRead(file.FileFullName);
        _streamReader ??= new StreamReader(_fileStream, Encoding.UTF8, true, BufferSize);
    }
}