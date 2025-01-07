using System;

namespace MatrixManagement
{
    public class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _cols;

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

        public void SetMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) != _rows || matrix.GetLength(1) != _cols)
                throw new ArgumentException("Matrix dimensions do not match.");
            _matrix = matrix;
        }

        public void SetMatrixFromConsole()
        {
            Console.WriteLine($"Enter elements for a {_rows}x{_cols} matrix:");

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"Enter element at [{i}, {j}]: ");
                    _matrix[i, j] = int.Parse(Console.ReadLine());
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
                    {
                        max = _matrix[i, j];
                    }
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
                    {
                        min = _matrix[i, j];
                    }
                }
            }
            return min;
        }
    }
}
