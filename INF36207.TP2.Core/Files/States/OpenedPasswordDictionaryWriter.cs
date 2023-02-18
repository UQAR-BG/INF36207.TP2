using INF36207.TP2.Files.Interfaces;
using File = INF36207.TP2.Files.Entities.File;

namespace INF36207.TP2.Files.States;

public class OpenedPasswordDictionaryWriter : ITextWriter
{
    private File? _file;
    
    public OpenedPasswordDictionaryWriter(string fileName)
    {
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
        using StreamWriter writer = new StreamWriter(_file!.FileFullName);
    }

    public void Close() { }

    public async Task Write(IEnumerable<string> content)
    {
        await using StreamWriter writer = new StreamWriter(_file!.FileFullName);
        
        foreach (string line in content)
        {
            await writer.WriteLineAsync(line);
        }
    }

    public async Task WriteLine(string line)
    {
        await using StreamWriter writer = new StreamWriter(_file!.FileFullName, append: true);
        await writer.WriteLineAsync(line);
    }
}