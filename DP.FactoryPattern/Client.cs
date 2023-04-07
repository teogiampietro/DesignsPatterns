using DP.FactoryPattern.LogisticFactory;

namespace DP.FactoryPattern;

class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the Road Logistic.");
        ClientCode(new RoadLogistics());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the Sea Logistic.");
        ClientCode(new SeaLogistics());

        Console.ReadKey();
    }

    public void ClientCode(Transport transport)
    {
        Console.WriteLine("Client: I'm not aware of the transport's class," +
            "but it still works.\n" + transport.CreateTransport());
    }
}
