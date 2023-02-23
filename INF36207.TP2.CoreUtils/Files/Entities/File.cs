using INF36207.TP2.Utils;
using System.IO;

namespace INF36207.TP2.Files.Entities
{
    public class File
    {
        private string _root;
        public string Root
        {
            get => _root;
            set
            {
                _root = value;
            }
        }

        private string _filePath;
        public string FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value;
            }
        }

        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
            }
        }

        private string _extension;
        public string Extension
        {
            get => _extension;
            set
            {
                _extension = value;
            }
        }

        private string _fileFullName;
        public string FileFullName
        {
            get => _fileFullName;
            set
            {
                _fileFullName = value;
            }
        }

        public int NumberOfLines { get; set; }

        public File(string fileFullName)
        {
            FilePathUtils.TryValidateFullFileName(fileFullName);
            AssignFileProperties(fileFullName);
        }

        private void AssignFileProperties(string fileFullName)
        {
            _root = Path.GetPathRoot(fileFullName) ?? string.Empty;
            _filePath = Path.GetDirectoryName(fileFullName) ?? string.Empty;
            _fileName = Path.GetFileName(fileFullName);
            _extension = Path.GetExtension(fileFullName);
            _fileFullName = fileFullName;
        }
    }
}