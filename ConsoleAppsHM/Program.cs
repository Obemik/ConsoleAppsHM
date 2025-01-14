using System;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is an example of a simple text checking program.";
            string wordToFind = "example";

            Func<string, string, bool> containsWord = (inputText, word) =>
                !string.IsNullOrWhiteSpace(inputText) && inputText.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool result = containsWord(text, wordToFind);

            Console.WriteLine($"Does the text contain the word \"{wordToFind}\"? {result}");
        }
    }
}