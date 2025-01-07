using MatrixManagement;

namespace MatrixManagementTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestSetMatrix_ValidData()
        {
            var matrix = new Matrix(2, 2);
            int[,] matrixData = { { 1, 2 }, { 3, 4 } };
            matrix.SetMatrix(matrixData);

            Assert.AreEqual(1, matrix.GetMaximum());
            Assert.AreEqual(4, matrix.GetMinimum());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSetMatrix_InvalidDimensions()
        {
            var matrix = new Matrix(3, 3);
            int[,] matrixData = { { 1, 2 }, { 3, 4 } };
            matrix.SetMatrix(matrixData); 
        }

        [TestMethod]
        public void TestGetMaximum_ValidMatrix()
        {
            var matrix = new Matrix(3, 3);
            int[,] matrixData = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix.SetMatrix(matrixData);

            int max = matrix.GetMaximum();
            Assert.AreEqual(9, max);
        }

        [TestMethod]
        public void TestGetMinimum_ValidMatrix()
        {
            var matrix = new Matrix(3, 3);
            int[,] matrixData = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            matrix.SetMatrix(matrixData);

            int min = matrix.GetMinimum();
            Assert.AreEqual(1, min);
        }
    }
}