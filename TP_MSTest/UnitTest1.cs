using MatrixManagement;

namespace MatrixManagementTests
{
    [TestClass]
    public class MatrixTests
    {
        private Matrix CreateMatrixFromArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            var matrix = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = array[i, j];

            return matrix;
        }

        [TestMethod]
        public void TestAdditionOfMatrices()
        {
            var matrix1 = CreateMatrixFromArray(new int[,] { { 1, 2 }, { 3, 4 } });
            var matrix2 = CreateMatrixFromArray(new int[,] { { 5, 6 }, { 7, 8 } });

            var result = matrix1 + matrix2;

            var expected = new int[,] { { 6, 8 }, { 10, 12 } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(expected[i, j], result[i, j]);
        }

        [TestMethod]
        public void TestMultiplicationWithScalar()
        {
            var matrix = CreateMatrixFromArray(new int[,] { { 1, 2 }, { 3, 4 } });

            var result = matrix * 2;

            var expected = new int[,] { { 2, 4 }, { 6, 8 } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(expected[i, j], result[i, j]);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var matrix1 = CreateMatrixFromArray(new int[,] { { 1, 2 }, { 3, 4 } });
            var matrix2 = CreateMatrixFromArray(new int[,] { { 1, 2 }, { 3, 4 } });

            Assert.IsTrue(matrix1 == matrix2);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var matrix1 = CreateMatrixFromArray(new int[,] { { 1, 2 }, { 3, 4 } });
            var matrix2 = CreateMatrixFromArray(new int[,] { { 5, 6 }, { 7, 8 } });

            Assert.IsTrue(matrix1 != matrix2);
        }
    }
}
