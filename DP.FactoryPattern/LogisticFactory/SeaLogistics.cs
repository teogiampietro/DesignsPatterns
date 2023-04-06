using DP.FactoryPattern.Product;

namespace DP.FactoryPattern.LogisticFactory;

class SeaLogistics : Transport
{
    public override ITransport LogisticFactory()
    {
        return new Ship();
    }
}
