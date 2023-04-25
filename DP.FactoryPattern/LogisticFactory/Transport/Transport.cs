namespace DP.FactoryPattern.LogisticFactory;

public abstract class Transport
{

    public abstract ITransport LogisticFactory();

    public string CreateTransport()
    {
        // Call the factory method to create a Product object.
        var transport = LogisticFactory();
        // Now, use the transport.
        var result = "LogisticFactory: The same LogisticFatory code has just worked with "
            + transport.Deliver();

        return result;
    }
}
