namespace INF36207.TP2.Exceptions;

public class IllegalTimespanException : Exception
{
    public IllegalTimespanException()
    {
    }

    public IllegalTimespanException(string message)
        : base(message)
    {
    }

    public IllegalTimespanException(string message, Exception inner)
        : base(message, inner)
    {
    }
}