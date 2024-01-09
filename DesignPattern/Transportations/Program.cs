internal class Program
{
    public static void Main(string[] args)
    {
        ClientCode(new TruckFactory(), 10);
        ClientCode(new ShipFactory(), 10);
        
        void ClientCode(TransportFactory factory, int distance)
        {
            Console.WriteLine("I'm not aware of this factory but it still work");
            var transport = factory.CreateTransport();
            Console.WriteLine(transport.GetCost(distance));
        }
    }
}
public interface ITransport
{
    double GetCost(int distance);
}

public class Truck : ITransport
{
    public double GetCost(int distince)
    {
        return 1 * distince;
    }
}

public class Ship : ITransport
{
    public double GetCost(int distance)
    {
        return 2 * distance;
    }
}

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}

public class TruckFactory : TransportFactory
{

    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

public class ShipFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}