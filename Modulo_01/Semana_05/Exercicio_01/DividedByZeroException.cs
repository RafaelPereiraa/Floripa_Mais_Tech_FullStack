using System.Runtime.Serialization;

[Serializable]
internal class DividedByZeroException : Exception
{
    public DividedByZeroException() : base("Não é possível dividir por zero.")
    {
    }

    public DividedByZeroException(string? message) : base(message)
    {
    }

    public DividedByZeroException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DividedByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}