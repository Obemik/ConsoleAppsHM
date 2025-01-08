using SquareGenerator;

class Program
{
    static void Main()
    {
        int sideLength = 5;
        char symbol = '*';

        string square = Square.GenerateSquare(sideLength, symbol);
        Console.WriteLine(square);
    }
}