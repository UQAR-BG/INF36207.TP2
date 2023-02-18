using INF36207.TP2.Files.Interfaces;
using File = INF36207.TP2.Files.Entities.File;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Files;

public class PasswordDictionaryWriter : ITextWriter
{
    private StreamWriter? _streamWriter;
    private File? _file;
    
    public PasswordDictionaryWriter() { }
    
    public PasswordDictionaryWriter(string fileName)
    {
        Open(fileName);
    }
    
    public bool IsOpened()
    {
        return CanWrite();
    }

    public bool IsClosed()
    {
        return !IsOpened();
    }
    
    public void Open(string fileName)
    {
        _file = new File(fileName);
        OpenStreamWriterIfNeeded(_file);
    }

    public void Close()
    {
        if (!IsOpened()) 
            return;
        
        _streamWriter?.Dispose();
        _streamWriter = null;
    }

    public async Task Write(IEnumerable<string> content)
    {
        foreach (string line in content)
        {
            await WriteLine(line);
        }
    }

    public async Task WriteLine(string line)
    {
        if (!CanWrite())
            throw new FileNotFoundException("Un fichier doit être ouvert pour l'écriture.");
        
        await _streamWriter!.WriteLineAsync(line);
    }
    
    private void OpenStreamWriterIfNeeded(File file)
    {
        if (!IsOpened())
        {
            OpenStreamWriter(file);
        }
    }
    
    private void OpenStreamWriter(File file)
    {
        _streamWriter = new StreamWriter(file.FileFullName);
    }

    private bool CanWrite()
    {
        return _file != null && _streamWriter != null;
    }
}