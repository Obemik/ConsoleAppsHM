using System;

namespace MathExpressionExample
{
    public class MathExpressionCalculator
    {
        public static int CalculateExpression(string expression)
        {
            try
            {
                string[] numbers = expression.Split('*');

                foreach (string num in numbers)
                {
                    if (string.IsNullOrWhiteSpace(num) || !int.TryParse(num, out _))
                    {
                        throw new ArgumentException("Expression contains invalid characters.");
                    }
                }

                int result = 1;
                foreach (var num in numbers)
                {
                    result *= int.Parse(num);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error processing the expression: " + ex.Message);
            }
        }
    }
}