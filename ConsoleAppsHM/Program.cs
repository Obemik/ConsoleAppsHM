using MatrixManagement;

class Program
{
    static void Main()
    {
        var matrix = new Matrix(3, 3);
        matrix.SetMatrixFromConsole();
        matrix.DisplayMatrix();

        Console.WriteLine($"Maximum value: {matrix.GetMaximum()}");
        Console.WriteLine($"Minimum value: {matrix.GetMinimum()}");
    }
}