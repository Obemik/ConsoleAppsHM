using System;

namespace LogicExpressionApp
{
    public class LogicEvaluator
    {
        public bool EvaluateExpression(string expression)
        {
            try
            {
                string[] parts = expression.Split(' ');

                if (parts.Length != 3)
                    throw new ArgumentException("Expression must be in the form 'a operator b'.");

                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[2]);
                string operatorSymbol = parts[1];

                switch (operatorSymbol)
                {
                    case ">":
                        return a > b;
                    case "<":
                        return a < b;
                    case ">=":
                        return a >= b;
                    case "<=":
                        return a <= b;
                    case "==":
                        return a == b;
                    case "!=":
                        return a != b;
                    default:
                        throw new ArgumentException("Invalid operator. Supported operators are: <, >, <=, >=, ==, !=.");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid expression format. Please check your input.", ex);
            }
        }
    }
}