using System;

namespace SquareGenerator
{
    public class Square
    {
        public static string GenerateSquare(int sideLength, char symbol)
        {
            if (sideLength <= 0)
                throw new ArgumentException("Side length must be greater than zero.");

            var result = string.Empty;

            for (int i = 0; i < sideLength; i++)
            {
                result += new string(symbol, sideLength) + "\n";
            }

            return result.TrimEnd(); 
        }
    }
}