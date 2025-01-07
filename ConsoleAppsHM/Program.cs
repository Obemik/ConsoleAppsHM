using System;
using ArraySorter;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter array elements separated by spaces:");
            string input = Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be empty.");
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine("Choose sorting order (1 - ascending, 2 - descending):");
            int choice = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input cannot be empty."));

            bool ascending = choice == 1;

            int[] sortedArray = Sorter.Sort(array, ascending);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", sortedArray));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}