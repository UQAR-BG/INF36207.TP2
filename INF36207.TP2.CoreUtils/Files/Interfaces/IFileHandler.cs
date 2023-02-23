namespace INF36207.TP2.Files.Interfaces
{
    public interface IFileHandler
    {
        bool IsOpened();
        bool IsClosed();
        void Open(string fileName);
        void Close();
    }
}