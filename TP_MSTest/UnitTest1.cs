using ArrayManagement;
using System;
using System.IO;

namespace ArrayManagementTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestShowEven()
        {
            var array = new IntArray(new[] { 1, 2, 3, 4, 5, 6 });

            var stringWriter = new StringWriter();
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

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            array.ShowOdd();  

            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Odd numbers:"));
            Assert.IsTrue(output.Contains("1"));
            Assert.IsTrue(output.Contains("3"));
            Assert.IsTrue(output.Contains("5"));
        }

        [TestMethod]
        public void TestShowEven_NoEvenNumbers()
        {
            var array = new IntArray(new[] { 1, 3, 5 });

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            array.ShowEven(); 

            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Even numbers:"));
            Assert.AreEqual("Even numbers: ", output);
        }

        [TestMethod]
        public void TestShowOdd_NoOddNumbers()
        {
            var array = new IntArray(new[] { 2, 4, 6 });

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            array.ShowOdd(); 

            var output = stringWriter.ToString().Trim();
            Assert.IsTrue(output.Contains("Odd numbers:"));
            Assert.AreEqual("Odd numbers: ", output); 
        }
    }
}
