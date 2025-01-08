using PalindromeChecker;

class Program
{
    static void Main()
    {
        int number = 1221;

        if (Palindrome.IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }
}