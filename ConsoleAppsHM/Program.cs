using System;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 3, -2, -5, -2, 7, 0, -8, -1, -8 };

            Func<int[], int[]> getUniqueNegativeNumbers = array => array.Where(num => num < 0).Distinct().ToArray();

            int[] uniqueNegativeNumbers = getUniqueNegativeNumbers(numbers);

            Console.WriteLine("Unique negative numbers: " + string.Join(", ", uniqueNegativeNumbers));
        }
    }
}