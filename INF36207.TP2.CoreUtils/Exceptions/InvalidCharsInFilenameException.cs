using System;

namespace INF36207.TP2.Exceptions
{
    public class InvalidCharsInFilenameException : Exception
    {
        public InvalidCharsInFilenameException()
        {
        }

        public InvalidCharsInFilenameException(string message)
            : base(message)
        {
        }

        public InvalidCharsInFilenameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}