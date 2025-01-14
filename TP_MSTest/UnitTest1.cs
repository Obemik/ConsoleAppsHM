using System;
using System.Linq;

namespace ArrayMinFinder.Tests
{
    [TestClass]
    public class ArrayMinFinderTests
    {
        [TestMethod]
        public void TestFindMin_WithPositiveAndNegativeNumbers()
        {
            Func<int[], int> findMin = array => array.Min();

            int[] numbers = { 10, -45, -3, 22, 90, 5 };

            Assert.AreEqual(-45, findMin(numbers), "The minimum value should be -45.");
        }

        [TestMethod]
        public void TestFindMin_WithAllPositiveNumbers()
        {
            Func<int[], int> findMin = array => array.Min();

            int[] numbers = { 10, 45, 3, 22, 90, 5 };

            Assert.AreEqual(3, findMin(numbers), "The minimum value should be 3.");
        }

        [TestMethod]
        public void TestFindMin_WithSingleElement()
        {
            Func<int[], int> findMin = array => array.Min();

            int[] numbers = { 42 };

            Assert.AreEqual(42, findMin(numbers), "The minimum value should be 42.");
        }

        [TestMethod]
        public void TestFindMin_WithEmptyArray()
        {
            Func<int[], int> findMin = array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array must not be null or empty.");
                }
                return array.Min();
            };

            int[] numbers = { };

            Assert.ThrowsException<ArgumentException>(() => findMin(numbers), "Empty array should throw an exception.");
        }
    }
}