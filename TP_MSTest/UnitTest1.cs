namespace AnonymousMethodExample.Tests
{
    [TestClass]
    public class AnonymousMethodTests
    {
        [TestMethod]
        public void TestIsEven_WithEvenNumber_ReturnsTrue()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = 8;
            bool result = isEven(testNumber);

            Assert.IsTrue(result, $"{testNumber} should be even.");
        }

        [TestMethod]
        public void TestIsEven_WithOddNumber_ReturnsFalse()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = 7;
            bool result = isEven(testNumber);

            Assert.IsFalse(result, $"{testNumber} should not be even.");
        }

        [TestMethod]
        public void TestIsEven_WithZero_ReturnsTrue()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = 0;
            bool result = isEven(testNumber);

            Assert.IsTrue(result, "0 should be considered even.");
        }

        [TestMethod]
        public void TestIsEven_WithNegativeEvenNumber_ReturnsTrue()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = -4;
            bool result = isEven(testNumber);

            Assert.IsTrue(result, $"{testNumber} should be even.");
        }

        [TestMethod]
        public void TestIsEven_WithNegativeOddNumber_ReturnsFalse()
        {
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = -5;
            bool result = isEven(testNumber);

            Assert.IsFalse(result, $"{testNumber} should not be even.");
        }
    }
}
