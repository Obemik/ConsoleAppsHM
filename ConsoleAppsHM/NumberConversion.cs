using System;

namespace NumberConversion
{
    public class NumberConverter
    {
        public int ConvertToInt(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Input string cannot be null or empty.");

                int result = int.Parse(input);

                return result;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Input string is not a valid number.");
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Input number is out of the range of the 'int' type.");
            }
        }
    }
}