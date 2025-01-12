using System;

namespace DelegateMethodsApp
{
    public class Methods
    {
        public void DisplayCurrentTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToString("HH:mm:ss")}");
        }

        public void DisplayCurrentDate()
        {
            Console.WriteLine($"Current Date: {DateTime.Now.ToString("yyyy-MM-dd")}");
        }

        public void DisplayCurrentDayOfWeek()
        {
            Console.WriteLine($"Current Day of Week: {DateTime.Now.DayOfWeek}");
        }

        public double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}