
using SquareGenerator;

namespace SquareGeneratorTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestGenerateSquare_ValidInput()
        {
            int sideLength = 3;
            char symbol = '#';

            string expected = "###\n###\n###";
            string result = Square.GenerateSquare(sideLength, symbol);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGenerateSquare_ZeroSideLength_ThrowsException()
        {
            Square.GenerateSquare(0, '*');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGenerateSquare_NegativeSideLength_ThrowsException()
        {
            Square.GenerateSquare(-1, '*');
        }

        [TestMethod]
        public void TestGenerateSquare_SingleCharacterSquare()
        {
            int sideLength = 1;
            char symbol = '@';

            string expected = "@";
            string result = Square.GenerateSquare(sideLength, symbol);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGenerateSquare_LargeSquare()
        {
            int sideLength = 2;
            char symbol = '$';

            string expected = "$$\n$$";
            string result = Square.GenerateSquare(sideLength, symbol);

            Assert.AreEqual(expected, result);
        }
    }
}