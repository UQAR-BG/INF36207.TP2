using INF36207.TP2.Files;
using INF36207.TP2.Files.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileNotFoundException = INF36207.TP2.Exceptions.FileNotFoundException;

namespace INF36207.TP2.Core.Tests.Files
{
    [TestClass]
    public class PasswordDictionaryReaderTests
    {
        private ITextReader _reader;
        private const string FileName = "TextFileForTests.txt";
        private const string EmptyFileName = "EmptyFileForTests.txt";

        [TestMethod]
        public void GivenNoFile_WhenGetNumberOfLines_ReturnZero()
        {
            // Arrange
            _reader = new PasswordDictionaryReader();

            // Act
            var result = _reader.GetNumberOfLines();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GivenNoFile_WhenNumberOfLines_ReturnZero()
        {
            // Arrange
            _reader = new PasswordDictionaryReader();

            // Act
            var result = _reader.NumberOfLines;

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GivenTextFile_WhenGetNumberOfLines_ReturnNumberOfLines()
        {
            // Arrange
            _reader = new PasswordDictionaryReader(FileName);
            int expectedNbrOfLines = 2;

            // Act
            var result = _reader.GetNumberOfLines();

            // Assert
            Assert.AreEqual(expectedNbrOfLines, result);

            _reader.Close();
        }

        [TestMethod]
        public void GivenTextFile_WhenNumberOfLines_ReturnNumberOfLines()
        {
            // Arrange
            _reader = new PasswordDictionaryReader(FileName);
            int expectedNbrOfLines = 2;

            // Act
            var result = _reader.NumberOfLines;

            // Assert
            Assert.AreEqual(expectedNbrOfLines, result);

            _reader.Close();
        }

        [TestMethod]
        public void GivenNonEmptyTextFile_WhenReadLine_ReturnStringLine()
        {
            // Arrange
            _reader = new PasswordDictionaryReader(FileName);

            // Act
            string firstLine = _reader.ReadLine();
            string secondLine = _reader.ReadLine();
            string thirdLine = _reader.ReadLine();

            // Assert
            Assert.AreEqual("hello", firstLine);
            Assert.AreEqual("world", secondLine);
            Assert.IsNull(thirdLine);

            _reader.Close();
        }

        [TestMethod]
        public void GivenNoFile_WhenReadLine_ThrowsException()
        {
            // Arrange
            _reader = new PasswordDictionaryReader();

            // Act

            // Assert
            Assert.ThrowsException<FileNotFoundException>(() => _reader.ReadLine());

            _reader.Close();
        }

        [TestMethod]
        public void GivenEmptyTextFile_WhenReadLine_ReturnNull()
        {
            // Arrange
            _reader = new PasswordDictionaryReader(EmptyFileName);

            // Act
            string line = _reader.ReadLine();

            // Assert
            Assert.IsNull(line);

            _reader.Close();
        }
    }
}