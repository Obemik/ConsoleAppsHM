using System;
using ArithmeticOperationsApp;

class Program
{
    static void Main()
    {
        var arithmeticOperations = new ArithmeticOperations();

        ArithmeticOperations.Operation add = new ArithmeticOperations.Operation(arithmeticOperations.Add);
        ArithmeticOperations.Operation subtract = new ArithmeticOperations.Operation(arithmeticOperations.Subtract);
        ArithmeticOperations.Operation multiply = new ArithmeticOperations.Operation(arithmeticOperations.Multiply);

        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Addition: {add.Invoke(num1, num2)}");
        Console.WriteLine($"Subtraction: {subtract.Invoke(num1, num2)}");
        Console.WriteLine($"Multiplication: {multiply.Invoke(num1, num2)}");
    }
}