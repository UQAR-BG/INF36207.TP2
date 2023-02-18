using System.Text;
using INF36207.TP2.Files.Interfaces;
using File = INF36207.TP2.Files.Entities.File;

namespace INF36207.TP2.Files.States;

public class OpenedPasswordDictionaryReader : ITextReader
{
    private const int BufferSize = 128;
    
    private FileStream? _stream;
    private StreamReader? _reader;
    private File? _file;
    
    public int NumberOfLines => GetNumberOfLines();

    public OpenedPasswordDictionaryReader(string fileName, FileStream? stream, StreamReader? reader)
    {
        _stream = stream;
        _reader = reader;
        
        Open(fileName);
    }
    
    public bool IsOpened()
    {
        return true;
    }

    public bool IsClosed()
    {
        return false;
    }

    public void Open(string fileName)
    {
        _file = new File(fileName);
        OpenStreamReader(_file);
        _file.NumberOfLines = CalculateNumberOfLines(_file);
    }

    public void Close() { }
    
    public int GetNumberOfLines()
    {
        return _file!.NumberOfLines;
    }

    public string? ReadLine()
    {
        return _reader!.ReadLine();
    }
    
    private int CalculateNumberOfLines(File file)
    {
        int numberOfLines = 0;

        while (_reader!.ReadLine() != null)
        {
            numberOfLines++;
        }
        _stream!.Position = 0;

        return numberOfLines;
    }
    
    private void OpenStreamReader(File file)
    {
        _stream = System.IO.File.OpenRead(file.FileFullName);
        _reader = new StreamReader(_stream, Encoding.UTF8, true, BufferSize);
    }
}