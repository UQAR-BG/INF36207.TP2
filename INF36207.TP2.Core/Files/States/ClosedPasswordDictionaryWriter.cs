using INF36207.TP2.Files.Interfaces;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Files.States;

public class ClosedPasswordDictionaryWriter : ITextWriter
{
    public ClosedPasswordDictionaryWriter()
    {
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

    public void Close() { }

    public Task Write(IEnumerable<string> content)
    {
        throw new FileNotFoundException("Un fichier doit être ouvert pour l'écriture.");
    }

    public Task WriteLine(string line)
    {
        throw new FileNotFoundException("Un fichier doit être ouvert pour l'écriture.");
    }
}