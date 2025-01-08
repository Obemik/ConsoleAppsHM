using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var wordToDigit = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        Console.WriteLine("Enter a number word (from zero to nine):");

        string input = Console.ReadLine().ToLower(); 

        try
        {
            if (wordToDigit.ContainsKey(input))
            {
                Console.WriteLine($"The digit is: {wordToDigit[input]}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a word from 'zero' to 'nine'.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}