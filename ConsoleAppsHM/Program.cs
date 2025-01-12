using ArrayManagement;
using System;

namespace ConsoleAppsHM
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new IntArray(new[] { 1, 2, 2, 3, 3, 3, 4 });

            array.ShowEven();

            array.ShowOdd();

            int distinctCount = array.CountDistinct();
            Console.WriteLine($"Number of distinct values: {distinctCount}");

            int equalTo3 = array.EqualToValue(3);
            Console.WriteLine($"Number of elements equal to 3: {equalTo3}");

            int equalTo5 = array.EqualToValue(5);
            Console.WriteLine($"Number of elements equal to 5: {equalTo5}");

            Console.ReadLine();
        }
    }
}