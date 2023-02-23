using INF36207.TP2.Files;
using INF36207.TP2.Files.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Core.Tests.Files
{
    [TestClass]
    public class PasswordDictionaryWriterTests
    {
        private ITextWriter _writer;
        private ITextReader _reader;
        private const string FileName = "TextFileForWriteTests.txt";

        [TestMethod]
        public void WhenWriteLine_FileContainsNumberOfLines()
        {
            // Arrange
            _writer = new PasswordDictionaryWriter(FileName);

            // Act
            _writer.WriteLine("hello");
            _writer.WriteLine("world");
            _writer.Close();

            _reader = new PasswordDictionaryReader(FileName);
            var result = _reader.NumberOfLines;
            _reader.Close();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GivenNoFile_WhenWriteLine_ThrowsException()
        {
            // Arrange
            _writer = new PasswordDictionaryWriter();

            // Act

            // Assert
            Assert.ThrowsException<FileNotFoundException>(() => _writer.WriteLine("Hello World"));
        }
    }
}