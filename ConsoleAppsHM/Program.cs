using System;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 14, 21, 3, 28, 35, 50, 70 };

            var count = numbers.Count(n => n % 7 == 0);

            Console.WriteLine($"Count of numbers divisible by 7: {count}");
        }
    }
}