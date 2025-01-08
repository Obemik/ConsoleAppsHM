using MathExpressionExample;
using System;

namespace MathExpressionTests
{
    [TestClass]
    public class MathExpressionCalculatorTests
    {
        [TestMethod]
        public void TestValidExpression()
        {
            string expression = "3*2*1*4";
            int result = MathExpressionCalculator.CalculateExpression(expression);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidExpression_InvalidCharacter()
        {
            string expression = "3*a*2";
            MathExpressionCalculator.CalculateExpression(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidExpression_Empty()
        {
            string expression = "*2*3";
            MathExpressionCalculator.CalculateExpression(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidExpression_EmptyString()
        {
            string expression = "";
            MathExpressionCalculator.CalculateExpression(expression);
        }

        [TestMethod]
        public void TestSingleNumberExpression()
        {
            string expression = "5";
            int result = MathExpressionCalculator.CalculateExpression(expression);
            Assert.AreEqual(5, result);
        }
    }
}