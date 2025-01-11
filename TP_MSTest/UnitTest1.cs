using System;
using System.IO;

namespace ArrayTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestShow()
        {
            var elements = new[] { 1, 2, 3, 4, 5 };
            var array = new Array(elements);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                array.Show();
                Assert.AreEqual("1, 2, 3, 4, 5\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestShowWithInfo()
        {
            var elements = new[] { 1, 2, 3, 4, 5 };
            var array = new Array(elements);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                array.Show("Array elements");
                Assert.AreEqual("Array elements: 1, 2, 3, 4, 5\r\n", sw.ToString());
            }
        }

        [TestMethod]
        public void TestConstructor_NullArray_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Array(null));
        }

        [TestMethod]
        public void TestGetElements()
        {
            var elements = new[] { 1, 2, 3, 4, 5 };
            var array = new Array(elements);
            CollectionAssert.AreEqual(elements, array.GetElements());
        }
    }
}