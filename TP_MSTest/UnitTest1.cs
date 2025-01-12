using ArrayManagement;
using System;
using System.Linq;

namespace ArrayManagementTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestCountDistinct()
        {
            var array = new IntArray(new[] { 1, 2, 2, 3, 3, 3, 4 });

            var distinctCount = array.CountDistinct();

            Assert.AreEqual(4, distinctCount);  
        }

        [TestMethod]
        public void TestEqualToValue()
        {
            var array = new IntArray(new[] { 1, 2, 2, 3, 3, 3, 4 });

            var countEqualTo2 = array.EqualToValue(2);
            var countEqualTo3 = array.EqualToValue(3);

            Assert.AreEqual(2, countEqualTo2);  
            Assert.AreEqual(3, countEqualTo3);  
        }

        [TestMethod]
        public void TestEqualToValue_NoMatches()
        {
            var array = new IntArray(new[] { 1, 2, 3, 4 });

            var countEqualTo5 = array.EqualToValue(5);

            Assert.AreEqual(0, countEqualTo5);  
        }

        [TestMethod]
        public void TestShowEven()
        {
            var array = new IntArray(new[] { 1, 2, 3, 4, 5, 6 });

            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            array.ShowEven();

            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Even numbers:"));
            Assert.IsTrue(output.Contains("2"));
            Assert.IsTrue(output.Contains("4"));
            Assert.IsTrue(output.Contains("6"));
        }

        [TestMethod]
        public void TestShowOdd()
        {
            var array = new IntArray(new[] { 1, 2, 3, 4, 5, 6 });

            var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            array.ShowOdd();

            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Odd numbers:"));
            Assert.IsTrue(output.Contains("1"));
            Assert.IsTrue(output.Contains("3"));
            Assert.IsTrue(output.Contains("5"));
        }
    }
}
