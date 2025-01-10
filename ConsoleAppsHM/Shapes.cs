using System;

namespace Shapes
{
    public abstract class Figure
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Figure
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and height must be greater than zero.");
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class RightTriangle : Figure
    {
        public double Base { get; }
        public double Height { get; }

        public RightTriangle(double baseLength, double height)
        {
            if (baseLength <= 0 || height <= 0)
                throw new ArgumentException("Base and height must be greater than zero.");
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class Trapezoid : Figure
    {
        public double Base1 { get; }
        public double Base2 { get; }
        public double Height { get; }

        public Trapezoid(double base1, double base2, double height)
        {
            if (base1 <= 0 || base2 <= 0 || height <= 0)
                throw new ArgumentException("Bases and height must be greater than zero.");
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
    }
}
