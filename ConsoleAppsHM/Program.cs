using System;
using System.Linq;

namespace ArrayMinFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMin = array => array.Min();

            int[] numbers = { 10, -45, -3, 22, 90, 5 };

            int min = findMin(numbers);

            Console.WriteLine($"Minimum value in the array: {min}");
        }
    }
}