using System;

namespace ArithmeticOperationsApp
{
    public class ArithmeticOperations
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public bool IsFibonacci(int number)
        {
            int a = 0, b = 1;

            while (b < number)
            {
                int temp = b;
                b += a;
                a = temp;
            }

            return b == number || number == 0;
        }

        public bool ExecutePredicate(Predicate<int> predicate, int number)
        {
            return predicate(number);
        }
    }
}