using System;
using System.Linq;

namespace ArrayMaxFinder.Tests
{
    [TestClass]
    public class ArrayMaxFinderTests
    {
        [TestMethod]
        public void TestFindMax_WithPositiveAndNegativeNumbers()
        {
            Func<int[], int> findMax = array => array.Max();

            int[] numbers = { 10, 45, -3, 22, 90, 5 };

            Assert.AreEqual(90, findMax(numbers), "The maximum value should be 90.");
        }

        [TestMethod]
        public void TestFindMax_WithAllNegativeNumbers()
        {
            Func<int[], int> findMax = array => array.Max();

            int[] numbers = { -10, -45, -3, -22, -90, -5 };

            Assert.AreEqual(-3, findMax(numbers), "The maximum value should be -3.");
        }

        [TestMethod]
        public void TestFindMax_WithSingleElement()
        {
            Func<int[], int> findMax = array => array.Max();

            int[] numbers = { 42 };

            Assert.AreEqual(42, findMax(numbers), "The maximum value should be 42.");
        }

        [TestMethod]
        public void TestFindMax_WithEmptyArray()
        {
            Func<int[], int> findMax = array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array must not be null or empty.");
                }
                return array.Max();
            };

            int[] numbers = { };

            Assert.ThrowsException<ArgumentException>(() => findMax(numbers), "Empty array should throw an exception.");
        }
    }
}
