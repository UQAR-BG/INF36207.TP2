using INF36207.TP2.Files.Interfaces;
using INF36207.TP2.Files.States;
using System.IO;

namespace INF36207.TP2.Files
{
    public class PasswordDictionaryReader : ITextReader
    {
        private ITextReader _reader;
        private FileStream _fileStream;
        private StreamReader _streamReader;

        public int NumberOfLines => GetNumberOfLines();

        public PasswordDictionaryReader()
        {
            _reader = new ClosedPasswordDictionaryReader(_fileStream, _streamReader);
        }

        public PasswordDictionaryReader(string fileName)
        {
            _reader = new OpenedPasswordDictionaryReader(fileName, _fileStream, _streamReader);
        }

        public bool IsOpened()
        {
            return _reader.IsOpened();
        }

        public bool IsClosed()
        {
            return _reader.IsClosed();
        }

        public void Open(string fileName)
        {
            _reader = new OpenedPasswordDictionaryReader(fileName, _fileStream, _streamReader);
        }

        public void Close()
        {
            _reader = new ClosedPasswordDictionaryReader(_fileStream, _streamReader);
        }

        public int GetNumberOfLines()
        {
            return _reader.NumberOfLines;
        }

        public string ReadLine()
        {
            return _reader.ReadLine();
        }
    }
}