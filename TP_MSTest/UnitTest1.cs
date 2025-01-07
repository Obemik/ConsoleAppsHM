using ArraySorter;

namespace ArraySorterTests
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void TestSortAscending()
        {
            int[] input = { 5, 3, 8, 1, 4 };
            int[] expected = { 1, 3, 4, 5, 8 };

            int[] result = Sorter.Sort(input, ascending: true);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSortDescending()
        {
            int[] input = { 5, 3, 8, 1, 4 };
            int[] expected = { 8, 5, 4, 3, 1 };

            int[] result = Sorter.Sort(input, ascending: false);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            int[] input = { };
            int[] expected = { };

            int[] result = Sorter.Sort(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray()
        {
            Sorter.Sort(null);
        }
    }
}