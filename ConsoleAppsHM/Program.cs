using System;
using System.Linq;

namespace ArrayMaxFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMax = array => array.Max();

            int[] numbers = { 10, 45, -3, 22, 90, 5 };

            int max = findMax(numbers);

            Console.WriteLine($"Maximum value in the array: {max}");
        }
    }
}