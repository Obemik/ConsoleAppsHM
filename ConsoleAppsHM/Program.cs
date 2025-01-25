using System;

interface IChair
{
    string GetDescription();
}

interface ISofa
{
    string GetDescription();
}

interface ICoffeeTable
{
    string GetDescription();
}

class ModernChair : IChair
{
    public string GetDescription() => "This is a modern chair.";
}

class ModernSofa : ISofa
{
    public string GetDescription() => "This is a modern sofa.";
}

class ModernCoffeeTable : ICoffeeTable
{
    public string GetDescription() => "This is a modern coffee table.";
}

class VictorianChair : IChair
{
    public string GetDescription() => "This is a Victorian chair.";
}

class VictorianSofa : ISofa
{
    public string GetDescription() => "This is a Victorian sofa.";
}

class VictorianCoffeeTable : ICoffeeTable
{
    public string GetDescription() => "This is a Victorian coffee table.";
}

interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
}

class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
}

class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
    public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
}

class FurnitureShop
{
    private readonly IFurnitureFactory _factory;

    public FurnitureShop(IFurnitureFactory factory)
    {
        _factory = factory;
    }

    public void DisplayFurnitureSet()
    {
        IChair chair = _factory.CreateChair();
        ISofa sofa = _factory.CreateSofa();
        ICoffeeTable coffeeTable = _factory.CreateCoffeeTable();

        Console.WriteLine(chair.GetDescription());
        Console.WriteLine(sofa.GetDescription());
        Console.WriteLine(coffeeTable.GetDescription());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Modern Furniture Set:");
        FurnitureShop modernShop = new FurnitureShop(new ModernFurnitureFactory());
        modernShop.DisplayFurnitureSet();

        Console.WriteLine();

        Console.WriteLine("Victorian Furniture Set:");
        FurnitureShop victorianShop = new FurnitureShop(new VictorianFurnitureFactory());
        victorianShop.DisplayFurnitureSet();

        Console.ReadLine();
    }
}
