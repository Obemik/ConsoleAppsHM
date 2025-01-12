using ArrayManagement;
using System;

namespace ArrayManagementTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestLess_ValidInput()
        {
            var array = new MyArray(new[] { 1, 2, 3, 4, 5 }); 
            int result = array.Less(4);
            Assert.AreEqual(3, result); 
        }

        [TestMethod]
        public void TestGreater_ValidInput()
        {
            var array = new MyArray(new[] { 1, 2, 3, 4, 5 });  
            int result = array.Greater(3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestLess_NoMatches()
        {
            var array = new MyArray(new[] { 5, 6, 7 });  
            int result = array.Less(5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestGreater_NoMatches()
        {
            var array = new MyArray(new[] { 1, 2, 3 });  
            int result = array.Greater(5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArray_EmptyArray_ThrowsException()
        {
            var array = new MyArray(new int[] { });  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArray_NullArray_ThrowsException()
        {
            var array = new MyArray(null);  
        }
    }
}