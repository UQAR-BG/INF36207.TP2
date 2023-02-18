using INF36207.TP2.Files.Interfaces;
using INF36207.TP2.Files.States;

namespace INF36207.TP2.Files;

public class PasswordDictionaryWriter : ITextWriter
{
    private ITextWriter _writer;

    public PasswordDictionaryWriter()
    {
        _writer = new ClosedPasswordDictionaryWriter();
    }
    
    public PasswordDictionaryWriter(string fileName)
    {
        _writer = new OpenedPasswordDictionaryWriter(fileName);
    }
    
    public bool IsOpened()
    {
        return _writer.IsOpened();
    }

    public bool IsClosed()
    {
        return _writer.IsClosed();
    }
    
    public void Open(string fileName)
    {
        _writer = new OpenedPasswordDictionaryWriter(fileName);
    }

    public void Close()
    {
        _writer = new ClosedPasswordDictionaryWriter();
    }

    public async Task Write(IEnumerable<string> content)
    {
        await _writer.Write(content);
    }

    public async Task WriteLine(string line)
    {
        await _writer.WriteLine(line);
    }
}