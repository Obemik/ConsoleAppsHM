using System;
using System.Linq;

namespace OddNumberFinder.Tests
{
    [TestClass]
    public class OddNumberFinderTests
    {
        [TestMethod]
        public void TestFindOddNumbers()
        {
            Func<int[], int[]> findOddNumbers = array => array.Where(x => x % 2 != 0).ToArray();

            int[] numbers = { 10, 45, 3, 22, 90, 5, 7, 8 };

            int[] expected = { 45, 3, 5, 7 };
            CollectionAssert.AreEqual(expected, findOddNumbers(numbers), "The odd numbers in the array are incorrect.");
        }

        [TestMethod]
        public void TestFindOddNumbers_WithOnlyEvenNumbers()
        {
            Func<int[], int[]> findOddNumbers = array => array.Where(x => x % 2 != 0).ToArray();

            int[] numbers = { 10, 22, 90, 8 };

            int[] expected = { };
            CollectionAssert.AreEqual(expected, findOddNumbers(numbers), "There should be no odd numbers.");
        }

        [TestMethod]
        public void TestFindOddNumbers_WithSingleOddNumber()
        {
            Func<int[], int[]> findOddNumbers = array => array.Where(x => x % 2 != 0).ToArray();

            int[] numbers = { 1 };

            int[] expected = { 1 };
            CollectionAssert.AreEqual(expected, findOddNumbers(numbers), "The array contains only one odd number.");
        }

        [TestMethod]
        public void TestFindOddNumbers_WithEmptyArray()
        {
            Func<int[], int[]> findOddNumbers = array => array.Where(x => x % 2 != 0).ToArray();

            int[] numbers = { };

            int[] expected = { };
            CollectionAssert.AreEqual(expected, findOddNumbers(numbers), "The array is empty, so no odd numbers should be returned.");
        }
    }
}
