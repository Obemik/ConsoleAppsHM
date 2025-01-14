namespace LambdaCubeExample.Tests
{
    [TestClass]
    public class LambdaCubeTests
    {
        [TestMethod]
        public void TestCalculateCube_WithPositiveNumber()
        {
            Func<int, int> calculateCube = number => number * number * number;

            int testNumber = 2;
            int expected = 8;

            Assert.AreEqual(expected, calculateCube(testNumber), $"Cube of {testNumber} should be {expected}.");
        }

        [TestMethod]
        public void TestCalculateCube_WithNegativeNumber()
        {
            Func<int, int> calculateCube = number => number * number * number;

            int testNumber = -4;
            int expected = -64;

            Assert.AreEqual(expected, calculateCube(testNumber), $"Cube of {testNumber} should be {expected}.");
        }

        [TestMethod]
        public void TestCalculateCube_WithZero()
        {
            Func<int, int> calculateCube = number => number * number * number;

            int testNumber = 0;
            int expected = 0;

            Assert.AreEqual(expected, calculateCube(testNumber), $"Cube of {testNumber} should be {expected}.");
        }
    }
}