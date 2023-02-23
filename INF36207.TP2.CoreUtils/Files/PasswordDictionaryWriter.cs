using INF36207.TP2.Files.Interfaces;
using INF36207.TP2.Files.States;
using System.Collections.Generic;

namespace INF36207.TP2.Files
{
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

        public void Write(IEnumerable<string> content)
        {
            _writer.Write(content);
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
        }
    }
}