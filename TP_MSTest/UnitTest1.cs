namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestCountPositiveNumbers_ValidInput()
        {
            int[] numbers = { -5, 0, 3, 7, -2, 9, -8, 4 };
            Func<int[], int> countPositiveNumbers = array => array.Count(num => num > 0);

            int result = countPositiveNumbers(numbers);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestCountPositiveNumbers_NoPositiveNumbers()
        {
            int[] numbers = { -5, -2, -8, -10 };
            Func<int[], int> countPositiveNumbers = array => array.Count(num => num > 0);

            int result = countPositiveNumbers(numbers);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountPositiveNumbers_AllPositiveNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Func<int[], int> countPositiveNumbers = array => array.Count(num => num > 0);

            int result = countPositiveNumbers(numbers);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCountPositiveNumbers_EmptyArray()
        {
            int[] numbers = { };
            Func<int[], int> countPositiveNumbers = array => array.Count(num => num > 0);

            int result = countPositiveNumbers(numbers);

            Assert.AreEqual(0, result);
        }
    }
}