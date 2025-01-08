using System;
using MathExpressionExample;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a mathematical expression:");
        string expression = Console.ReadLine();

        try
        {
            int result = MathExpressionCalculator.CalculateExpression(expression);
            Console.WriteLine($"Result: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}