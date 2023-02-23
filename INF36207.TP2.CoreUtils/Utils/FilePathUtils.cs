using INF36207.TP2.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace INF36207.TP2.Utils
{
    public static class FilePathUtils
    {
        private static readonly Dictionary<char, bool> InvalidCharacters = GetInvalidFileNameChars();

        public static bool TryValidateFullFileName(string fullFileName)
        {
            try
            {
                Path.GetPathRoot(fullFileName);
                Path.GetDirectoryName(fullFileName);
                string fileName = Path.GetFileName(fullFileName);
                ValidateIfCharsValid(fileName);
                Path.GetExtension(fullFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        public static void ValidateIfCharsValid(string fileName)
        {
            foreach (var c in fileName.Where(c => InvalidCharacters.ContainsKey(c)))
            {
                throw new InvalidCharsInFilenameException($"Invalid character: {c} in filename.");
            }
        }

        private static Dictionary<char, bool> GetInvalidFileNameChars()
        {
            return Path.GetInvalidFileNameChars().ToDictionary(c => c, c => true);
        }
    }
}