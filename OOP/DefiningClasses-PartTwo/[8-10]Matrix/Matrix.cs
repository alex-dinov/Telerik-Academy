using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_Matrix
{
    class Matrix<T>
    {
        private readonly int row;
        private readonly int col;
        private T[,] matrix;

        public Matrix(int row,int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentException("rows and colons cannot be negative!");
            }

            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        public Matrix():this(0,0)
        {
        }

        public int Row
        {
            get { return this.row; }
        }

        public int Col
        {
            get { return this.col; }
        }

        public T this[int row,int col]
        {
            get 
            {
                if (row >= this.Row || col >= this.Col || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
                T result = matrix[row, col];
                return result;
            }
            set
            {
                if (row >= this.Row || col >= this.Col || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
                matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Row != b.Row || a.Col != b.Col)
            {
                throw new FormatException("Matrixes must have same dimensions!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(a.Row, a.Col);
                for (int i = 0; i < a.Row; i++)
                {
                    for (int j = 0; j < a.Col; j++)
                    {
                        result[i, j] = (T)Convert.ChangeType(Convert.ToDecimal(a[i, j]) + Convert.ToDecimal(b[i, j]),typeof(T));
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Row != b.Row || a.Col != b.Col)
            {
                throw new FormatException("Matrixes must have same dimensions!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(a.Row, a.Col);
                for (int i = 0; i < a.Row; i++)
                {
                    for (int j = 0; j < a.Col; j++)
                    {
                        result[i, j] = (T)Convert.ChangeType(Convert.ToDecimal(a[i, j]) - Convert.ToDecimal(b[i, j]), typeof(T));
                    }
                }
                return result;
            }
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Col != b.Row)
            {
                throw new FormatException("First matrix columns number must be equal to second matrix rows number!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(a.Row, b.Col);
                for (int i = 0; i < a.Row; i++)
                {
                    for (int j = 0; j < b.Col; j++)
                    {
                        for (int k = 0; k < a.Col; k++)
                        {
                            result[i, j] = (T)Convert.ChangeType(Convert.ToDecimal(result[i, j]) + (Convert.ToDecimal(a[i, j]) * Convert.ToDecimal(b[i, j])), typeof(T));
                        }
                    }
                }
                return result;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (!matrix[i,j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (!matrix[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder output=new StringBuilder();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    output.Append(matrix[i,j]+" ");
                }
                output.AppendLine();
            }
            return output.ToString();
        }
    }
}
