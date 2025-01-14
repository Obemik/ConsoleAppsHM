using System.Linq;
using System.Collections.Generic;

namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestUniqueNegativeNumbers()
        {
            int[] numbers = { -1, -2, 3, -2, 4, -5, -1, -3, 7, 0 };

            var uniqueNegativeNumbers = numbers
                .Where(n => n < 0)
                .Distinct()
                .ToList();

            var expected = new List<int> { -1, -2, -5, -3 };
            CollectionAssert.AreEqual(expected, uniqueNegativeNumbers);
        }

        [TestMethod]
        public void TestUniqueNegativeNumbers_EmptyArray()
        {
            int[] numbers = { };

            var uniqueNegativeNumbers = numbers
                .Where(n => n < 0)
                .Distinct()
                .ToList();

            Assert.AreEqual(0, uniqueNegativeNumbers.Count);
        }

        [TestMethod]
        public void TestUniqueNegativeNumbers_NoNegativeNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var uniqueNegativeNumbers = numbers
                .Where(n => n < 0)
                .Distinct()
                .ToList();

            Assert.AreEqual(0, uniqueNegativeNumbers.Count);
        }
    }
}