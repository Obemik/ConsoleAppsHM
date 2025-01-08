using System;
using LogicExpressionApp;

namespace LogicExpressionApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a logical expression (e.g., 3 > 2): ");
            string expression = Console.ReadLine();

            var evaluator = new LogicEvaluator();

            try
            {
                bool result = evaluator.EvaluateExpression(expression);
                Console.WriteLine($"Result: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}