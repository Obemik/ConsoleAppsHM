using System.Linq;

namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestGetUniqueNegativeNumbers_ValidInput()
        {
            int[] numbers = { -5, 3, -2, -5, -2, 7, 0, -8, -1, -8 };
            Func<int[], int[]> getUniqueNegativeNumbers = array => array.Where(num => num < 0).Distinct().ToArray();

            int[] result = getUniqueNegativeNumbers(numbers);

            CollectionAssert.AreEquivalent(new int[] { -5, -2, -8, -1 }, result);
        }

        [TestMethod]
        public void TestGetUniqueNegativeNumbers_NoNegativeNumbers()
        {
            int[] numbers = { 1, 3, 7, 0, 5 };
            Func<int[], int[]> getUniqueNegativeNumbers = array => array.Where(num => num < 0).Distinct().ToArray();

            int[] result = getUniqueNegativeNumbers(numbers);

            CollectionAssert.AreEqual(new int[] { }, result);
        }

        [TestMethod]
        public void TestGetUniqueNegativeNumbers_AllNegativeNumbers()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };
            Func<int[], int[]> getUniqueNegativeNumbers = array => array.Where(num => num < 0).Distinct().ToArray();

            int[] result = getUniqueNegativeNumbers(numbers);

            CollectionAssert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, result);
        }

        [TestMethod]
        public void TestGetUniqueNegativeNumbers_EmptyArray()
        {
            int[] numbers = { };
            Func<int[], int[]> getUniqueNegativeNumbers = array => array.Where(num => num < 0).Distinct().ToArray();

            int[] result = getUniqueNegativeNumbers(numbers);

            CollectionAssert.AreEqual(new int[] { }, result);
        }
    }
}