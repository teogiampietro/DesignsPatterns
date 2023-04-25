using DP.FactoryPattern.Product;

namespace DP.FactoryPattern.LogisticFactory;

class RiverLogistic : Transport
{
    public override ITransport LogisticFactory()
    {
        return new Boat();
    }
}
