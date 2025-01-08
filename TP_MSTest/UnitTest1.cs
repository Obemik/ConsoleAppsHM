using System;

[TestClass]
public class ArrayFilterTests
{
    [TestMethod]
    public void TestFilterArray_ValidArrays()
    {
        var arrayFilter = new ArrayFilter();
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] expected = { 1, 2, -1 };

        int[] result = arrayFilter.FilterArray(originalArray, filterArray);

        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestFilterArray_NullOriginalArray_ThrowsException()
    {
        var arrayFilter = new ArrayFilter();
        int[] filterArray = { 6, 88, 7 };

        arrayFilter.FilterArray(null, filterArray);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestFilterArray_NullFilterArray_ThrowsException()
    {
        var arrayFilter = new ArrayFilter();
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };

        arrayFilter.FilterArray(originalArray, null);
    }

    [TestMethod]
    public void TestFilterArray_EmptyFilterArray()
    {
        var arrayFilter = new ArrayFilter();
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { };
        int[] expected = { 1, 2, 6, -1, 88, 7, 6 };

        int[] result = arrayFilter.FilterArray(originalArray, filterArray);

        CollectionAssert.AreEqual(expected, result);
    }
}