using System;

namespace LambdaCubeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> calculateCube = number => number * number * number;

            int testNumber = 3;
            Console.WriteLine($"Cube of {testNumber} is: {calculateCube(testNumber)}");

            testNumber = -2;
            Console.WriteLine($"Cube of {testNumber} is: {calculateCube(testNumber)}");

            testNumber = 0;
            Console.WriteLine($"Cube of {testNumber} is: {calculateCube(testNumber)}");
        }
    }
}