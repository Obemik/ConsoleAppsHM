using System;
using NumberConversionApp; 

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1. Decimal to Binary");
        Console.WriteLine("2. Decimal to Hexadecimal");

        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number to convert:");

        int inputNumber = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (choice == 1)
            {
                string result = NumberConverter.DecimalToBinary(inputNumber);
                Console.WriteLine($"Binary: {result}");
            }
            else if (choice == 2)
            {
                string result = NumberConverter.DecimalToHexadecimal(inputNumber);
                Console.WriteLine($"Hexadecimal: {result}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}