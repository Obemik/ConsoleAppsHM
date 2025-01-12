using System;
using MatrixManagement;

class Program
{
    static void Main()
    {
        var matrix1 = new Matrix(3, 3);
        var matrix2 = new Matrix(3, 3);

        Console.WriteLine("Enter values for the first matrix:");
        matrix1.SetMatrixFromConsole();

        Console.WriteLine("Enter values for the second matrix:");
        matrix2.SetMatrixFromConsole();

        matrix1.DisplayMatrix();
        matrix2.DisplayMatrix();

        var sumMatrix = matrix1 + matrix2;
        Console.WriteLine("Sum of matrices:");
        sumMatrix.DisplayMatrix();

        var diffMatrix = matrix1 - matrix2;
        Console.WriteLine("Difference of matrices:");
        diffMatrix.DisplayMatrix();

        Console.WriteLine($"Maximum value in first matrix: {matrix1.GetMaximum()}");
        Console.WriteLine($"Minimum value in second matrix: {matrix2.GetMinimum()}");
    }
}