using System;
using DeviceNamespace;

class Program
{
    static void Main()
    {
        Device[] devices = {
            new Kettle("Kettle", "A device used to boil water."),
            new Microwave("Microwave", "A device used to heat food."),
            new Car("Car", "A motor vehicle used for transportation."),
            new Steamboat("Steamboat", "A vessel powered by steam.")
        };

        foreach (var device in devices)
        {
            device.Show();
            device.Desc();
            device.Sound();
            Console.WriteLine();
        }
    }
}