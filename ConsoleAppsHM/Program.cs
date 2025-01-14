using System;

namespace AnonymousMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = 42;
            Console.WriteLine($"Is {testNumber} even? {isEven(testNumber)}");

            testNumber = 17;
            Console.WriteLine($"Is {testNumber} even? {isEven(testNumber)}");
        }
    }
}