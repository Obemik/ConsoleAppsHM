using System;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 14, 21, 28, 35, 5, 10, 15, 20 };

            Func<int[], int> countMultiplesOfSeven = array => array.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);

            Console.WriteLine($"Count of numbers divisible by 7: {result}");
        }
    }
}