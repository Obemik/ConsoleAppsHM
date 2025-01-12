using System;

namespace MatrixManagement
{
    public class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _cols;

        public int this[int row, int col]
        {
            get => _matrix[row, col];
            set => _matrix[row, col] = value;
        }

        public Matrix()
        {
            _rows = 3;
            _cols = 3;
            _matrix = new int[_rows, _cols];
        }

        public Matrix(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _matrix = new int[rows, cols];
        }

        public void SetMatrixFromConsole()
        {
            Console.WriteLine($"Enter elements for a {_rows}x{_cols} matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"Enter element at [{i}, {j}]: ");
                    _matrix[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(_matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int GetMaximum()
        {
            int max = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_matrix[i, j] > max)
                        max = _matrix[i, j];
                }
            }
            return max;
        }

        public int GetMinimum()
        {
            int min = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_matrix[i, j] < min)
                        min = _matrix[i, j];
                }
            }
            return min;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._cols != b._cols)
                throw new ArgumentException("Matrix dimensions must match.");

            var result = new Matrix(a._rows, a._cols);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._cols; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._cols != b._cols)
                throw new ArgumentException("Matrix dimensions must match.");

            var result = new Matrix(a._rows, a._cols);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._cols; j++)
                    result[i, j] = a[i, j] - b[i, j];

            return result;
        }

        public static Matrix operator *(Matrix a, int scalar)
        {
            var result = new Matrix(a._rows, a._cols);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._cols; j++)
                    result[i, j] = a[i, j] * scalar;

            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Matrix other)
                return false;

            if (_rows != other._rows || _cols != other._cols)
                return false;

            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    if (_matrix[i, j] != other[i, j])
                        return false;

            return true;
        }

        public static bool operator ==(Matrix a, Matrix b) => a.Equals(b);

        public static bool operator !=(Matrix a, Matrix b) => !a.Equals(b);

        public override int GetHashCode() => _matrix.GetHashCode();
    }
}
