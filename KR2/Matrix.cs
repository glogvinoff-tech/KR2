using System;
using System.Text;

namespace MatrixCalculator
{
    public class Matrix
    {
        public double[,] Data { get; set; }
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными.");

            Rows = rows;
            Cols = cols;
            Data = new double[rows, cols];
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                result.Append("│ ");
                for (int j = 0; j < Cols; j++)
                {
                    result.Append($"{Data[i, j],10:F4}");
                    if (j < Cols - 1)
                        result.Append("  ");
                }
                result.Append(" │\r\n");
            }
            return result.ToString();
        }

        // Метод для красивого вывода матрицы в компактном формате
        public string ToCompactString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    result.Append($"{Data[i, j],8:F2}");
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }
    }
}