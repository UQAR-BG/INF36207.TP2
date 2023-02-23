using System;

namespace INF36207.TP2.Exceptions
{
    public class UnsupportedFileTypeException : Exception
    {
        public UnsupportedFileTypeException()
        {
        }

        public UnsupportedFileTypeException(string message)
            : base(message)
        {
        }

        public UnsupportedFileTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}