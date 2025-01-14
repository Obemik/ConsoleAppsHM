using System.Linq;

namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestCountNumbersDivisibleBySeven()
        {
            int[] numbers = { 7, 14, 21, 3, 28, 35, 50, 70 };

            var count = numbers.Count(n => n % 7 == 0);

            Assert.AreEqual(6, count);
        }

        [TestMethod]
        public void TestCountNumbersDivisibleBySeven_EmptyArray()
        {
            int[] numbers = { };

            var count = numbers.Count(n => n % 7 == 0);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestCountNumbersDivisibleBySeven_NoMultiples()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var count = numbers.Count(n => n % 7 == 0);

            Assert.AreEqual(0, count);
        }
    }
}