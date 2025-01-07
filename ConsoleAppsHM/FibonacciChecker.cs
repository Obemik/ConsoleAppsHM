namespace FibonacciChecker;

public static class FibonacciUtils
{
    public static bool IsFibonacciNumber(int number)
    {
        if (number < 0)
        {
            return false; 
        }

        bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }

        return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
    }
}