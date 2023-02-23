using INF36207.TP2.Files.Interfaces;

namespace INF36207.TP2.Files.States;

public class OpenedPasswordDictionaryWriter : ITextWriter
{
    private Entities.File? _file;
    
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
        _file = new Entities.File(fileName);

        if (!File.Exists(fileName))
        {
            using StreamWriter writer = new StreamWriter(_file!.FileFullName);
        } else
        {
            File.Create(fileName).Dispose();
        }
    }

    public void Close() { }

    public void Write(IEnumerable<string> content)
    {
        using StreamWriter writer = new StreamWriter(_file!.FileFullName);
        
        foreach (string line in content)
        {
            writer.WriteLine(line);
        }
    }

    public void WriteLine(string line)
    {
        using StreamWriter writer = new StreamWriter(_file!.FileFullName, append: true);
        writer.WriteLine(line);
    }
}