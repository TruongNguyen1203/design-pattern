Console.WriteLine("Order victorian furniture: ");
var victorianFurniture = new VitorianFactory();
var victorian = new FurnitureClient(victorianFurniture);
victorian.ShowProducts();

Console.WriteLine("Order modern furniture: ");
var modernFurniture = new ModernFactory();
var modern = new FurnitureClient(modernFurniture);
modern.ShowProducts();
public class FurnitureShop
{
    public interface IChair
    {
        int HasLegs();
        bool SitOn();
    }

    public interface ITable
    {
        string GetShape();
    }

    public interface ISofa
    {
        int GetDemension();
    }

    public class VictorianChair : IChair
    {
        public int HasLegs()
        {
            return 4;
        }

        public bool SitOn()
        {
            return true;
        }
    }

    public class ModernChair : IChair
    {
        public int HasLegs()
        {
            return 0;
        }

        public bool SitOn()
        {
            return false;
        }
    }

    public class VictorianSofa : ISofa
    {
        public int GetDemension()
        {
            return 10;
        }
    }

    public class ModernSofa : ISofa
    {
        public int GetDemension()
        {
            return 5;
        }
    }

    public class VitorianTable : ITable
    {
        public string GetShape()
        {
            return "Rectangle";
        }
    }

    public class ModernTable : ITable
    {
        public string GetShape()
        {
            return "Oval";
        }
    }

    public interface IFurnitureFactory
    {
        public ISofa CreateSofa();
        public IChair CreateChair();
        public ITable CreateTable();
    }

    
}

public class VitorianFactory : FurnitureShop.IFurnitureFactory
{
    public FurnitureShop.ISofa CreateSofa()
    {
        return new FurnitureShop.VictorianSofa();
    }

    public FurnitureShop.IChair CreateChair()
    {
        return new FurnitureShop.VictorianChair();
    }

    public FurnitureShop.ITable CreateTable()
    {
        return new FurnitureShop.VitorianTable();
    }
}

public class ModernFactory : FurnitureShop.IFurnitureFactory
{
    public FurnitureShop.ISofa CreateSofa()
    {
        return new FurnitureShop.ModernSofa();
    }

    public FurnitureShop.IChair CreateChair()
    {
        return new FurnitureShop.ModernChair();
    }

    public FurnitureShop.ITable CreateTable()
    {
        return new FurnitureShop.ModernTable();
    }
}

//Public Client
public class FurnitureClient
{
    private readonly FurnitureShop.IChair _chair;
    private readonly FurnitureShop.ISofa _sofa;
    private readonly FurnitureShop.ITable _table;

    public FurnitureClient(FurnitureShop.IFurnitureFactory furnitureFactory)
    {
        _chair = furnitureFactory.CreateChair();
        _sofa = furnitureFactory.CreateSofa();
        _table = furnitureFactory.CreateTable();
    }

    public void ShowProducts()
    {
        Console.WriteLine("I want to get entire related in furniture: ");

        Console.WriteLine($"Chair: {_chair.GetType()}: {_chair.HasLegs()} - {_chair.SitOn()}");
        Console.WriteLine($"Sofa: {_sofa.GetType()}: {_sofa.GetDemension()}");
        Console.WriteLine($"Table: {_table.GetType()}: {_table.GetShape()}");
    }
}
