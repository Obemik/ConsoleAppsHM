using BinaryConversion;

namespace BinaryConversionTests
{
    [TestClass]
    public class BinaryConverterTests
    {
        [TestMethod]
        public void TestConvertBinaryToDecimal_ValidInput()
        {
            var converter = new BinaryConverter();
            int result = converter.ConvertBinaryToDecimal("1101");  

            Assert.AreEqual(13, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertBinaryToDecimal_InvalidInput()
        {
            var converter = new BinaryConverter();
            converter.ConvertBinaryToDecimal("1021");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertBinaryToDecimal_EmptyInput()
        {
            var converter = new BinaryConverter();
            converter.ConvertBinaryToDecimal("");  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvertBinaryToDecimal_OutOfRangeInput()
        {
            var converter = new BinaryConverter();
            converter.ConvertBinaryToDecimal("100000000000000000000000000000000");  
        }
    }
}