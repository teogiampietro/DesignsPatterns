using DP.FactoryPattern.Product;

namespace DP.FactoryPattern.LogisticFactory;

class RoadLogistics : Transport
{
    public override ITransport LogisticFactory()
    {
        return new Truck();
    }
}
