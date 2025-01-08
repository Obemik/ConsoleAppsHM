namespace NumberConversionApp
{
    public class NumberConverter
    {
        public static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber < 0) 
                throw new ArgumentOutOfRangeException("Number must be non-negative.");
            return Convert.ToString(decimalNumber, 2);
        }

        public static string DecimalToHexadecimal(int decimalNumber)
        {
            if (decimalNumber < 0) 
                throw new ArgumentOutOfRangeException("Number must be non-negative.");
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }
    }
}