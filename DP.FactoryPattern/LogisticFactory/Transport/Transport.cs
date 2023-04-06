namespace DP.FactoryPattern.LogisticFactory;

abstract class Transport
{

    public abstract ITransport LogisticFactory();

    public string CreateTransport()
    {
        // Call the factory method to create a Product object.
        var transport = LogisticFactory();
        // Now, use the product.
        var result = "Creator: The same creator's code has just worked with "
            + transport.Deliver();

        return result;
    }
}
