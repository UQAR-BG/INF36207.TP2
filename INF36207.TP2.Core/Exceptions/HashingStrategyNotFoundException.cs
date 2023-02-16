namespace INF36207.TP2.Exceptions;

public class HashingStrategyNotFoundException : Exception
{
    public HashingStrategyNotFoundException()
    {
    }

    public HashingStrategyNotFoundException(string message)
        : base(message)
    {
    }

    public HashingStrategyNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}