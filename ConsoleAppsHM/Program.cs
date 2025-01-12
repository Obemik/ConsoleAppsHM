using System;
using ArithmeticOperationsApp;

class Program
{
    static void Main()
    {
        var arithmeticOperations = new ArithmeticOperations();

        ArithmeticOperation addOperation = new ArithmeticOperation(arithmeticOperations.Add);
        ArithmeticOperation subtractOperation = new ArithmeticOperation(arithmeticOperations.Subtract);
        ArithmeticOperation multiplyOperation = new ArithmeticOperation(arithmeticOperations.Multiply);

        double a = 5;
        double b = 3;

        Console.WriteLine($"Addition: {arithmeticOperations.ExecuteOperation(addOperation, a, b)}");
        Console.WriteLine($"Subtraction: {arithmeticOperations.ExecuteOperation(subtractOperation, a, b)}");
        Console.WriteLine($"Multiplication: {arithmeticOperations.ExecuteOperation(multiplyOperation, a, b)}");
    }
}