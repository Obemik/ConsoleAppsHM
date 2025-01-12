using System;
using DelegateMethodsApp;

namespace DelegateMethodsAppTests
{
    [TestClass]
    public class MethodsTests
    {
        private Methods _methods;

        [TestInitialize]
        public void Setup()
        {
            _methods = new Methods();
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            double result = _methods.CalculateTriangleArea(10, 5);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestCalculateRectangleArea()
        {
            double result = _methods.CalculateRectangleArea(10, 5);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestAreaGreaterThan10Predicate()
        {
            Predicate<double> isAreaGreaterThan10 = area => area > 10;
            bool result = isAreaGreaterThan10.Invoke(25);
            Assert.IsTrue(result);

            result = isAreaGreaterThan10.Invoke(5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestActionDisplayCurrentTime()
        {
           
            Action action = new Action(_methods.DisplayCurrentTime);
            action.Invoke();
        }

        [TestMethod]
        public void TestActionDisplayCurrentDate()
        {
            Action action = new Action(_methods.DisplayCurrentDate);
            action.Invoke();
        }

        [TestMethod]
        public void TestActionDisplayCurrentDayOfWeek()
        {
            Action action = new Action(_methods.DisplayCurrentDayOfWeek);
            action.Invoke();
        }
    }
}