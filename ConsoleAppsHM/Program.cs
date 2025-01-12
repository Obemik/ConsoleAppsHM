using System;
using System.Collections.Generic;
using ArrayOperationsApp;

class Program
{
    static void Main()
    {
        var arrayOperations = new ArrayOperations();

        ArrayOperations.ArrayOperation evenNumbers = new ArrayOperations.ArrayOperation(arrayOperations.GetEvenNumbers);
        ArrayOperations.ArrayOperation oddNumbers = new ArrayOperations.ArrayOperation(arrayOperations.GetOddNumbers);
        ArrayOperations.ArrayOperation primeNumbers = new ArrayOperations.ArrayOperation(arrayOperations.GetPrimeNumbers);
        ArrayOperations.ArrayOperation fibonacciNumbers = new ArrayOperations.ArrayOperation(arrayOperations.GetFibonacciNumbers);

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 21, 34, 55 };

        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers.Invoke(numbers)));
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers.Invoke(numbers)));
        Console.WriteLine("Prime Numbers: " + string.Join(", ", primeNumbers.Invoke(numbers)));
        Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", fibonacciNumbers.Invoke(numbers)));
    }
}