namespace LambdaExample.Tests
{
    [TestClass]
    public class LambdaTests
    {
        [TestMethod]
        public void TestCountMultiplesOfSeven_ValidInput()
        {
            int[] numbers = { 7, 14, 21, 28, 35, 5, 10, 15, 20 };
            Func<int[], int> countMultiplesOfSeven = array => array.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCountMultiplesOfSeven_NoMultiples()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Func<int[], int> countMultiplesOfSeven = array => array.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountMultiplesOfSeven_EmptyArray()
        {
            int[] numbers = { };
            Func<int[], int> countMultiplesOfSeven = array => array.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountMultiplesOfSeven_AllMultiples()
        {
            int[] numbers = { 7, 14, 21, 28 };
            Func<int[], int> countMultiplesOfSeven = array => array.Count(num => num % 7 == 0);

            int result = countMultiplesOfSeven(numbers);

            Assert.AreEqual(4, result);
        }
    }
}