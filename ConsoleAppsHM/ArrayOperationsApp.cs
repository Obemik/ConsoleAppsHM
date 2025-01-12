using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayOperationsApp
{
    public class ArrayOperations
    {
        public delegate List<int> ArrayOperation(int[] array);

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
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public bool IsFibonacci(int number)
        {
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b == number || number == 0;
        }

        public List<int> GetEvenNumbers(int[] array)
        {
            return array.Where(IsEven).ToList();
        }

        public List<int> GetOddNumbers(int[] array)
        {
            return array.Where(IsOdd).ToList();
        }

        public List<int> GetPrimeNumbers(int[] array)
        {
            return array.Where(IsPrime).ToList();
        }

        public List<int> GetFibonacciNumbers(int[] array)
        {
            return array.Where(IsFibonacci).ToList();
        }
    }
}