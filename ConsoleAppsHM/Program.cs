using System;
using System.Collections.Generic;
using CityNamespace;

class Program
{
    static void Main()
    {
        try
        {
            var city = new City();

            Console.WriteLine("Enter city name:");
            city.SetCityName(Console.ReadLine() ?? throw new InvalidOperationException("City name cannot be null."));

            Console.WriteLine("Enter country name:");
            city.SetCountryName(Console.ReadLine() ?? throw new InvalidOperationException("Country name cannot be null."));

            Console.WriteLine("Enter population:");
            city.SetPopulation(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Population cannot be null.")));

            Console.WriteLine("Enter phone code:");
            city.SetPhoneCode(Console.ReadLine() ?? throw new InvalidOperationException("Phone code cannot be null."));

            Console.WriteLine("Enter districts (comma separated):");
            var districtsInput = Console.ReadLine() ?? throw new InvalidOperationException("Districts cannot be null.");
            var districts = new List<string>(districtsInput.Split(','));
            city.SetDistricts(districts);

            Console.WriteLine("\nCity information:");
            city.DisplayCityInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}