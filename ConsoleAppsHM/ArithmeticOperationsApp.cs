using System;

namespace ArithmeticOperationsApp
{
    public class ArithmeticOperations
    {
        public delegate int Operation(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int ExecuteOperation(Operation operation, int x, int y)
        {
            return operation(x, y);
        }
    }
}