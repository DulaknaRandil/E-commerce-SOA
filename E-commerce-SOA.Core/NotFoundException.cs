namespace E_commerce_SOA.Core;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    { }
}
