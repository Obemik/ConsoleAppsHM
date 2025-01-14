using System;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 0, 3, 7, -2, 9, -8, 4 };

            Func<int[], int> countPositiveNumbers = array => array.Count(num => num > 0);

            int result = countPositiveNumbers(numbers);

            Console.WriteLine($"Count of positive numbers: {result}");
        }
    }
}