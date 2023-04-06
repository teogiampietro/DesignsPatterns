

using DP.FactoryPattern.LogisticFactory;

namespace DP.FactoryPattern.Product;

class Ship : ITransport
{
    public string Deliver()
    {
        return "{Result of a Ship Logistic}";
    }
}
