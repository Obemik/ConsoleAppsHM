namespace AnonymousMethodExample.Tests
{
    [TestClass]
    public class AnonymousMethodTests
    {
        [TestMethod]
        public void TestCalculateSquare_WithPositiveNumber()
        {
            Func<int, int> calculateSquare = delegate (int number)
            {
                return number * number;
            };

            int testNumber = 4;
            int expected = 16;

            Assert.AreEqual(expected, calculateSquare(testNumber), $"Square of {testNumber} should be {expected}.");
        }

        [TestMethod]
        public void TestCalculateSquare_WithNegativeNumber()
        {
            Func<int, int> calculateSquare = delegate (int number)
            {
                return number * number;
            };

            int testNumber = -7;
            int expected = 49;

            Assert.AreEqual(expected, calculateSquare(testNumber), $"Square of {testNumber} should be {expected}.");
        }

        [TestMethod]
        public void TestCalculateSquare_WithZero()
        {
            Func<int, int> calculateSquare = delegate (int number)
            {
                return number * number;
            };

            int testNumber = 0;
            int expected = 0;

            Assert.AreEqual(expected, calculateSquare(testNumber), $"Square of {testNumber} should be {expected}.");
        }
    }
}