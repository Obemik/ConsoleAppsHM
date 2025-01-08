using System;

namespace PalindromeChecker
{
    public class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            string numStr = Math.Abs(number).ToString();

            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}