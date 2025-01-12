using System;
using ArithmeticOperationsApp;

class Program
{
    static void Main()
    {
        var arithmeticOperations = new ArithmeticOperations();

        Predicate<int> isEven = new Predicate<int>(arithmeticOperations.IsEven);
        Predicate<int> isOdd = new Predicate<int>(arithmeticOperations.IsOdd);
        Predicate<int> isPrime = new Predicate<int>(arithmeticOperations.IsPrime);
        Predicate<int> isFibonacci = new Predicate<int>(arithmeticOperations.IsFibonacci);

        int number = 13;

        Console.WriteLine($"Is {number} even? {arithmeticOperations.ExecutePredicate(isEven, number)}");
        Console.WriteLine($"Is {number} odd? {arithmeticOperations.ExecutePredicate(isOdd, number)}");
        Console.WriteLine($"Is {number} prime? {arithmeticOperations.ExecutePredicate(isPrime, number)}");
        Console.WriteLine($"Is {number} a Fibonacci number? {arithmeticOperations.ExecutePredicate(isFibonacci, number)}");
    }
}