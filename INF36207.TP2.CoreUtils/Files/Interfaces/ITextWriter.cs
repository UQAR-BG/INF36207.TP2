using System.Collections.Generic;

namespace INF36207.TP2.Files.Interfaces
{
    public interface ITextWriter : IFileHandler
    {
        void Write(IEnumerable<string> content);
        void WriteLine(string line);
    }
}