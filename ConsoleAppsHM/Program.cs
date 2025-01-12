using System;
using DelegateMethodsApp;

class Program
{
    static void Main()
    {
        var methods = new Methods();

        Action displayCurrentTime = new Action(methods.DisplayCurrentTime);
        Action displayCurrentDate = new Action(methods.DisplayCurrentDate);
        Action displayCurrentDayOfWeek = new Action(methods.DisplayCurrentDayOfWeek);
        
        Predicate<double> isAreaGreaterThan10 = area => area > 10;

        Func<double, double, double> calculateTriangleArea = methods.CalculateTriangleArea;

        Func<double, double, double> calculateRectangleArea = methods.CalculateRectangleArea;

        displayCurrentTime.Invoke();
        displayCurrentDate.Invoke();
        displayCurrentDayOfWeek.Invoke();

        double triangleArea = calculateTriangleArea(10, 5);
        double rectangleArea = calculateRectangleArea(10, 5);

        Console.WriteLine($"Triangle Area: {triangleArea}");
        Console.WriteLine($"Rectangle Area: {rectangleArea}");

        if (isAreaGreaterThan10.Invoke(triangleArea))
        {
            Console.WriteLine("Triangle area is greater than 10");
        }
        else
        {
            Console.WriteLine("Triangle area is not greater than 10");
        }
    }
}