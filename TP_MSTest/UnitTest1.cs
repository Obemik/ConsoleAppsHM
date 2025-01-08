
using NumberConversionApp;

namespace NumberConversionAppTests
{
    [TestClass]
    public class NumberConverterTests
    {
        [TestMethod]
        public void TestDecimalToBinary_ValidInput()
        {
            int input = 10;
            string expected = "1010";
            string result = NumberConverter.DecimalToBinary(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDecimalToBinary_NegativeInput_ThrowsException()
        {
            int input = -5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumberConverter.DecimalToBinary(input));
        }

        [TestMethod]
        public void TestDecimalToHexadecimal_ValidInput()
        {
            int input = 255;
            string expected = "FF";
            string result = NumberConverter.DecimalToHexadecimal(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDecimalToHexadecimal_NegativeInput_ThrowsException()
        {
            int input = -10;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumberConverter.DecimalToHexadecimal(input));
        }
    }
}