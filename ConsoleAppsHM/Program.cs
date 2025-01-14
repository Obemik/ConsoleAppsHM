using System;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, 2, 3, -4, 5, 0, 7, -8 };

            var count = numbers.Count(n => n > 0);

            Console.WriteLine($"Count of positive numbers: {count}");
        }
    }
}