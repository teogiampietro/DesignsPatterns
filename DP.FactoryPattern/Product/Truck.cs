using DP.FactoryPattern.LogisticFactory;

namespace DP.FactoryPattern.Product;

class Truck : ITransport
{
    public string Deliver()
    {
        return "{Result of a Truck Logistic}";
    }
}
