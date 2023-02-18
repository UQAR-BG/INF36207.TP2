using INF36207.TP2.Files.Interfaces;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Files.States;

public class ClosedPasswordDictionaryReader : ITextReader
{
    private readonly FileStream? _stream;
    private readonly StreamReader? _reader;
    
    public int NumberOfLines => GetNumberOfLines();

    public ClosedPasswordDictionaryReader(FileStream? stream, StreamReader? reader)
    {
        _stream = stream;
        _reader = reader;
        
        Close();
    }
    
    public bool IsOpened()
    {
        return false;
    }

    public bool IsClosed()
    {
        return true;
    }

    public void Open(string fileName) { }

    public void Close()
    {
        _reader?.Close();
        _stream?.Close();
    }
    
    public int GetNumberOfLines()
    {
        return 0;
    }

    public string? ReadLine()
    {
        throw new FileNotFoundException("Un fichier doit être ouvert avant de pouvoir le lire.");
    }
}