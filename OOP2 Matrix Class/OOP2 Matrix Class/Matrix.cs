using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Matrix_Class
{
    internal class Matrix
    {
        private double[,] matrix;

        public Matrix(double[,] array)
        {
            matrix = (double[,])array.Clone();
        }

        public Matrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        public Matrix() : this(5, 5)
        {
            for (int i = 0; i < 5; i++)
            {
                matrix[i, i] = 1;
            }
        }

        public double[] GetRow(int row)
        {
            if (row < 0 || row >= matrix.GetLength(0))
                throw new IndexOutOfRangeException("Invalid row index.");

            double[] result = new double[matrix.GetLength(1)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matrix[row, i];
            }
            return result;
        }
        public void SetElement(int row, int col, double value)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
                throw new IndexOutOfRangeException("Invalid index.");
            matrix[row, col] = value;
        }
        public double[] GetColumn(int col)
        {
            if (col < 0 || col >= matrix.GetLength(1))
                throw new IndexOutOfRangeException("Invalid column index.");

            double[] result = new double[matrix.GetLength(0)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matrix[i, col];
            }
            return result;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
                throw new ArgumentException("Matrices dimensions do not match.");

            Matrix result = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(1) != b.matrix.GetLength(0))
                throw new ArgumentException("Matrices dimensions do not match for multiplication.");

            Matrix result = new Matrix(a.matrix.GetLength(0), b.matrix.GetLength(1));
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < a.matrix.GetLength(1); k++)
                    {
                        result.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                    }
                }
            }
            return result;
        }
        public static explicit operator double[](Matrix m)
        {
            double[] flattenedArray = new double[m.matrix.Length];
            int k = 0;
            for (int i = 0; i < m.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m.matrix.GetLength(1); j++)
                {
                    flattenedArray[k++] = m.matrix[i, j];
                }
            }
            return flattenedArray;
        }

        public static implicit operator double[,](Matrix m)
        {
            return m.matrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j]} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public double GetSum()
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        public static void CopyFrame(Matrix source, Matrix destination)
        {
            if (source.matrix.GetLength(0) != destination.matrix.GetLength(0) || source.matrix.GetLength(1) != destination.matrix.GetLength(1))
                throw new ArgumentException("Source and destination matrices dimensions do not match.");

            int rows = source.matrix.GetLength(0);
            int cols = source.matrix.GetLength(1);

            // Copy first and last row
            for (int j = 0; j < cols; j++)
            {
                destination.matrix[0, j] = source.matrix[0, j];
                destination.matrix[rows - 1, j] = source.matrix[rows - 1, j];
            }

            // Copy first and last column
            for (int i = 0; i < rows; i++)
            {
                destination.matrix[i, 0] = source.matrix[i, 0];
                destination.matrix[i, cols - 1] = source.matrix[i, cols - 1];
            }
        }

        public static Matrix? MaxSumMatrix(params Matrix[] matrices)
        {
            Matrix? maxMatrix = null;
            double maxSum = double.MinValue;

            foreach (Matrix matrix in matrices)
            {
                double sum = matrix.GetSum();
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxMatrix = matrix;
                }
            }
            return maxMatrix;
        }
        public static Matrix Transpose(Matrix m)
        {
            Matrix result = new Matrix(m.matrix.GetLength(1), m.matrix.GetLength(0));
            for (int i = 0; i < m.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m.matrix.GetLength(1); j++)
                {
                    result.matrix[j, i] = m.matrix[i, j];
                }
            }
            return result;
        }

    }
}

    }
}
