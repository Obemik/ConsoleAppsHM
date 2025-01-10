using System;
using Shapes;

class Program
{
    static void Main()
    {
        Figure[] figures = new Figure[]
        {
            new Rectangle(4, 5),
            new Circle(3),
            new RightTriangle(6, 8),
            new Trapezoid(3, 5, 4)
        };

        foreach (var figure in figures)
        {
            Console.WriteLine($"Figure: {figure.GetType().Name}, Area: {figure.CalculateArea():F2}");
        }
    }
}