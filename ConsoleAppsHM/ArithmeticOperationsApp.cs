using System;

namespace ArithmeticOperationsApp
{
    public delegate double ArithmeticOperation(double a, double b);

    public class ArithmeticOperations
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double ExecuteOperation(ArithmeticOperation operation, double a, double b)
        {
            return operation(a, b);
        }
    }
}