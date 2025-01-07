using System;
using FibonacciChecker;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number to check if it is a Fibonacci number:");
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be null."));

            bool result = FibonacciUtils.IsFibonacciNumber(number);
            Console.WriteLine(result
                ? $"{number} is a Fibonacci number."
                : $"{number} is NOT a Fibonacci number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}