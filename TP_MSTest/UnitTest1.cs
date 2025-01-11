using System;

namespace ArrayTests
{
    [TestClass]
    public class MyArrayTests
    {
        [TestMethod]
        public void Show_ShouldDisplayCorrectInformation()
        {
            var array = new MyArray(new int[] { 1, 2, 3 });

            using (var consoleOutput = new ConsoleOutput())
            {
                array.Show("Test array");
                string result = consoleOutput.GetOuput();
                
                Assert.IsTrue(result.Contains("Test array: 1, 2, 3"));
            }
        }

        [TestMethod]
        public void Max_ShouldReturnMaximumValue()
        {
            var array = new MyArray(new int[] { 1, 2, 3, 10, 5 });

            var result = array.Max();

            Assert.AreEqual(10, result);
        }
        
        [TestMethod]
        public void Min_ShouldReturnMinimumValue()
        {
            var array = new MyArray(new int[] { 1, 2, 3, 10, 5 });

            var result = array.Min();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Avg_ShouldReturnAverageValue()
        {
            var array = new MyArray(new int[] { 1, 2, 3, 10, 5 });

            var result = array.Avg();

            Assert.AreEqual(4.2f, result, 0.1);
        }

        [TestMethod]
        public void Search_ShouldReturnTrueIfValueExists()
        {
            var array = new MyArray(new int[] { 1, 2, 3, 10, 5 });

            var result = array.Search(3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Search_ShouldReturnFalseIfValueNotExists()
        {
            var array = new MyArray(new int[] { 1, 2, 3, 10, 5 });

            var result = array.Search(7);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SortAsc_ShouldSortArrayAscending()
        {
            var array = new MyArray(new int[] { 3, 1, 2, 5, 4 });

            array.SortAsc();
            var result = array.GetData();

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void SortDesc_ShouldSortArrayDescending()
        {
            var array = new MyArray(new int[] { 3, 1, 2, 5, 4 });

            array.SortDesc();
            var result = array.GetData();

            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, result);
        }

        [TestMethod]
        public void SortByParam_ShouldSortArrayAccordingToParameter()
        {
            var arrayAsc = new MyArray(new int[] { 3, 1, 2, 5, 4 });
            var arrayDesc = new MyArray(new int[] { 3, 1, 2, 5, 4 });

            arrayAsc.SortByParam(true); 
            var resultAsc = arrayAsc.GetData();
            arrayDesc.SortByParam(false);
            var resultDesc = arrayDesc.GetData();

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, resultAsc);
            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, resultDesc);
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter _stringWriter;
        private readonly System.IO.TextWriter _originalOutput;

        public ConsoleOutput()
        {
            _stringWriter = new System.IO.StringWriter();
            _originalOutput = Console.Out;
            Console.SetOut(_stringWriter);
        }

        public string GetOuput()
        {
            return _stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(_originalOutput);
            _stringWriter.Dispose();
        }
    }
}
