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

            city = city + 50000;
            Console.WriteLine($"\nAfter population increase: {city.GetPopulation()}");

            city = city - 100000;
            Console.WriteLine($"After population decrease: {city.GetPopulation()}");

            var city2 = new City();
            city2.SetPopulation(2000000);
            Console.WriteLine($"Are cities equal by population? {city == city2}");

            Console.WriteLine($"Is city1 population greater than city2? {city > city2}");
            Console.WriteLine($"Is city1 population less than city2? {city < city2}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
