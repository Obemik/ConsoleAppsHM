using Shapes;
using System;

namespace ShapeTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            var rectangle = new Rectangle(4, 5);
            Assert.AreEqual(20, rectangle.CalculateArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleInvalidDimensions()
        {
            var rectangle = new Rectangle(-4, 5);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var circle = new Circle(3);
            Assert.AreEqual(Math.PI * 3 * 3, circle.CalculateArea(), 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleInvalidRadius()
        {
            var circle = new Circle(-3);
        }

        [TestMethod]
        public void TestRightTriangleArea()
        {
            var triangle = new RightTriangle(6, 8);
            Assert.AreEqual(24, triangle.CalculateArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRightTriangleInvalidDimensions()
        {
            var triangle = new RightTriangle(0, 8);
        }

        [TestMethod]
        public void TestTrapezoidArea()
        {
            var trapezoid = new Trapezoid(3, 5, 4);
            Assert.AreEqual(16, trapezoid.CalculateArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidInvalidDimensions()
        {
            var trapezoid = new Trapezoid(3, 0, 4);
        }
    }
}