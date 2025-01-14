using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Func<string, bool> containsWord = word => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string wordToSearch = "fox";
            bool result = containsWord(wordToSearch);

            Console.WriteLine($"Does the text contain the word '{wordToSearch}'? {result}");
        }
    }
}