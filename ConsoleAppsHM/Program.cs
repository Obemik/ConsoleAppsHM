using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, -2, 3, -2, 4, -5, -1, -3, 7, 0 };

            var uniqueNegativeNumbers = numbers
                .Where(n => n < 0)       
                .Distinct()               
                .ToList();             

            Console.WriteLine("Unique negative numbers:");
            foreach (var num in uniqueNegativeNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}