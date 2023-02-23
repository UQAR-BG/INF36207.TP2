using INF36207.TP2.Files.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace INF36207.TP2.Files.States
{
    public class OpenedPasswordDictionaryWriter : ITextWriter
    {
        private StreamWriter _writer;
        private Entities.File _file;

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
                _writer = new StreamWriter(_file.FileFullName);
                _writer.Close();
            }
            else
            {
                File.Create(fileName).Dispose();
            }
        }

        public void Close() 
        {
            _writer.Close();
        }

        public void Write(IEnumerable<string> content)
        {
            _writer = new StreamWriter(_file.FileFullName);

            foreach (string line in content)
            {
                _writer.WriteLine(line);
            }
            Close();
        }

        public void WriteLine(string line)
        {
            _writer = new StreamWriter(_file.FileFullName, append: true);
            _writer.WriteLine(line);
            Close();
        }
    }
}