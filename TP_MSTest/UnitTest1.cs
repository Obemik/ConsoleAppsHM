using System.Linq;

namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestCountPositiveNumbers()
        {
            int[] numbers = { -1, 2, 3, -4, 5, 0, 7, -8 };

            var count = numbers.Count(n => n > 0);

            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void TestCountPositiveNumbers_EmptyArray()
        {
            int[] numbers = { };

            var count = numbers.Count(n => n > 0);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestCountPositiveNumbers_NoPositiveNumbers()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };

            var count = numbers.Count(n => n > 0);

            Assert.AreEqual(0, count);
        }
    }
}