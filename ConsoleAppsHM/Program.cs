using System;

namespace AnonymousMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> calculateSquare = delegate (int number)
            {
                return number * number;
            };

            int testNumber = 5;
            Console.WriteLine($"Square of {testNumber} is: {calculateSquare(testNumber)}");

            testNumber = -3;
            Console.WriteLine($"Square of {testNumber} is: {calculateSquare(testNumber)}");
        }
    }
}