using System;
using BinaryConversion;

class Program
{
    static void Main()
    {
        var converter = new BinaryConverter();
        
        Console.WriteLine("Enter a binary number:");

        string input = Console.ReadLine();

        try
        {
            int decimalNumber = converter.ConvertBinaryToDecimal(input);
            Console.WriteLine($"The decimal equivalent is: {decimalNumber}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}