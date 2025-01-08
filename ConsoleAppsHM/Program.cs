using System;
using NumberConversion;

class Program
{
    static void Main()
    {
        var converter = new NumberConverter();
        
        Console.WriteLine("Enter a number:");

        string input = Console.ReadLine();

        try
        {
            int number = converter.ConvertToInt(input);
            Console.WriteLine($"The converted number is: {number}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}