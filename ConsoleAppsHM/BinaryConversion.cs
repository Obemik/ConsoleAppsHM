using System;

namespace BinaryConversion
{
    public class BinaryConverter
    {
        public int ConvertBinaryToDecimal(string binaryInput)
        {
            try
            {
                if (string.IsNullOrEmpty(binaryInput))
                    throw new ArgumentException("Input string cannot be null or empty.");

                foreach (char c in binaryInput)
                {
                    if (c != '0' && c != '1')
                    {
                        throw new ArgumentException("Input string must only contain '0' and '1'.");
                    }
                }

                int decimalNumber = Convert.ToInt32(binaryInput, 2);

                return decimalNumber;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Input string is not a valid binary number.");
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Input number is out of the range of the 'int' type.");
            }
        }
    }
}