using NumberConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConversionTests
{
    [TestClass]
    public class NumberConverterTests
    {
        [TestMethod]
        public void TestConvertToInt_ValidInput()
        {
            var converter = new NumberConverter();
            int result = converter.ConvertToInt("123");

            Assert.AreEqual(123, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertToInt_InvalidInput()
        {
            var converter = new NumberConverter();
            converter.ConvertToInt("abc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertToInt_EmptyInput()
        {
            var converter = new NumberConverter();
            converter.ConvertToInt("");  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertToInt_OutOfRangeInput()
        {
            var converter = new NumberConverter();
            converter.ConvertToInt("2147483648");  
        }
    }
}