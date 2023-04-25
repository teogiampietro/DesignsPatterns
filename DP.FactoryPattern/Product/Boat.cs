using DP.FactoryPattern.LogisticFactory;

namespace DP.FactoryPattern.Product;

public class Boat : ITransport
{
    public string Deliver()
    {
        return "Soy un bote transportando";
    }
}
