namespace RangeProductCalculator;

public static class Calculator
{
    public static long GetProductInRange(int start, int end)
    {
        if (start > end)
        {
            throw new ArgumentException("Start of range cannot be greater than end.");
        }

        long product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }
        return product;
    }
}