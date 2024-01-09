//new Client().Main();

 
//1. Create Abstract Product
public interface IAbstractProductA
{
    string UsefulFunctionA();
}

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}

//2. Create Concrete Product
class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Product A1";
    }
}

class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Product A2";
    }
}

class ConreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Product B1";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"B1 collabarator with {result}";
    }
}

class ConreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Product B2";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"B2 collabarator with {result}";
    }
}
//3. Create AbstractFactory
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}
//4. Create ConcreteFactory
class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConreteProductB1();
    }
}

class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConreteProductB2();
    }
}

//Client
class Client
{
    public void Main()
    {
        Console.WriteLine("Factory 1");
        ClientMethod(new ConcreteFactory1());
        
        Console.WriteLine("Factory 2");
        ClientMethod(new ConcreteFactory2());
        
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var a = factory.CreateProductA();
        var b = factory.CreateProductB();
        Console.WriteLine(b.UsefulFunctionB());
        Console.WriteLine(b.AnotherUsefulFunctionB(a));
    }
}

