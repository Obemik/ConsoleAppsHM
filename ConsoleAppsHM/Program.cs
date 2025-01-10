using System;
using HumanHierarchy;

class Program
{
    static void Main()
    {
        var builder = new Builder("John", 35, "Carpenter");
        var sailor = new Sailor("Mike", 40, "Captain");
        var pilot = new Pilot("Anna", 30, "Airways Inc.");

        Console.WriteLine(builder.GetInfo());
        Console.WriteLine(sailor.GetInfo());
        Console.WriteLine(pilot.GetInfo());

        Console.WriteLine(builder.BuildHouse());
        Console.WriteLine(sailor.Navigate());
        Console.WriteLine(pilot.FlyPlane());
    }
}