using System;
using System.Linq;

namespace OddNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> findOddNumbers = array => array.Where(x => x % 2 != 0).ToArray();

            int[] numbers = { 10, 45, 3, 22, 90, 5, 7, 8 };

            int[] oddNumbers = findOddNumbers(numbers);

            Console.WriteLine("Odd numbers in the array:");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}