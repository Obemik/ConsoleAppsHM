using System;
using System.Collections.Generic;

public interface ICar
{
    void Drive();
}

public class BasicCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a basic car.");
    }
}

public class SportsCarDecorator : ICar
{
    private readonly ICar _car;

    public SportsCarDecorator(ICar car)
    {
        _car = car;
    }

    public void Drive()
    {
        _car.Drive();
        Console.WriteLine("Driving a sports car!");
    }
}

public class LuxuryCarDecorator : ICar
{
    private readonly ICar _car;

    public LuxuryCarDecorator(ICar car)
    {
        _car = car;
    }

    public void Drive()
    {
        _car.Drive();
        Console.WriteLine("Driving a luxury car!");
    }
}

public class Engine
{
    public void Start() => Console.WriteLine("Engine started.");
    public void Stop() => Console.WriteLine("Engine stopped.");
}

public class Transmission
{
    public void Shift() => Console.WriteLine("Transmission shifted.");
}

public class AirConditioning
{
    public void TurnOn() => Console.WriteLine("Air conditioning turned on.");
}

public class CarFacade
{
    private readonly Engine _engine;
    private readonly Transmission _transmission;
    private readonly AirConditioning _airConditioning;

    public CarFacade()
    {
        _engine = new Engine();
        _transmission = new Transmission();
        _airConditioning = new AirConditioning();
    }

    public void StartCar()
    {
        _engine.Start();
        _transmission.Shift();
        _airConditioning.TurnOn();
    }

    public void StopCar()
    {
        _engine.Stop();
    }
}

public class CarType
{
    public string Model { get; }
    public string Color { get; }

    public CarType(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Displaying {Model} of color {Color} at position ({x}, {y}).");
    }
}

public class CarFactory
{
    private readonly Dictionary<string, CarType> _carTypes = new Dictionary<string, CarType>();

    public CarType GetCarType(string model, string color)
    {
        string key = $"{model}-{color}";
        if (!_carTypes.ContainsKey(key))
        {
            _carTypes[key] = new CarType(model, color);
        }

        return _carTypes[key];
    }
}

public interface IRealSubject
{
    void Request();
}

public class RealSubject : IRealSubject
{
    public void Request()
    {
        Console.WriteLine("Real subject is processing the request.");
    }
}

public class Proxy : IRealSubject
{
    private readonly RealSubject _realSubject;

    public Proxy()
    {
        _realSubject = new RealSubject();
    }

    public void Request()
    {
        Console.WriteLine("Proxy: Checking permissions before accessing real subject...");
        _realSubject.Request();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Decorator ===");
        ICar myCar = new BasicCar();
        myCar.Drive();

        Console.WriteLine("---");

        myCar = new SportsCarDecorator(myCar);
        myCar.Drive();

        Console.WriteLine("---");

        myCar = new LuxuryCarDecorator(myCar);
        myCar.Drive();

        Console.WriteLine("\n");

        Console.WriteLine("=== Facade ===");
        CarFacade carFacade = new CarFacade();
        carFacade.StartCar();
        carFacade.StopCar();

        Console.WriteLine("\n");

        Console.WriteLine("=== Flyweight ===");
        CarFactory carFactory = new CarFactory();

        CarType car1 = carFactory.GetCarType("Sedan", "Red");
        car1.Display(10, 20);

        CarType car2 = carFactory.GetCarType("Sedan", "Red"); 
        car2.Display(30, 40);

        CarType car3 = carFactory.GetCarType("SUV", "Blue");
        car3.Display(50, 60);

        Console.WriteLine("\n");

        Console.WriteLine("=== Proxy ===");
        IRealSubject subject = new Proxy();
        subject.Request();

        Console.ReadKey();
    }
}
