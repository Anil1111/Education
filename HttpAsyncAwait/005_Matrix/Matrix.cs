using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Matrix
{
    class Matrix
    {
        private int[][] matrix;

        public Matrix(int n, int m)
        {
            matrix = new int[Math.Abs(n)][];
            for (int i = 0; i < Math.Abs(n); i++)
            {
                matrix[i] = new int[Math.Abs(m)];
            }

            Fill();
        }

        private void Fill()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rnd.Next(10, 50);
                }
            }
        }

        public void ChangeSize(int row, int col)
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрицы не могут быть меньше или равными 0");
                return;
            }
            var mNew = new int[row][];
            for (int i = 0; i < row; i++)
            {
                mNew[i] = new int[col];
            }

            for (int i = 0; i < Math.Min(matrix.Length, row); i++)
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, col); j++)
                {
                    mNew[i][j] = matrix[i][j];
                }
            }
            Random rnd = new Random();
            if (row > matrix.Length)
            {
                for (int i = matrix.Length; i < row; i++)
                {
                    for (int j = 0; j < Math.Min(col, matrix[0].Length); j++)
                    {

                    }
                }
            }

            if (col > matrix[0].Length)
            {
                for (int i = matrix[0].Length; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        mNew[j][i] = rnd.Next(10, 90);
                    }
                }
            }

            matrix = mNew;
        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startCol < 0 || endRow > matrix.Length || endCol > matrix[0].Length)
            {
                Console.WriteLine("Попытка обращения за пределы массива");
                return;
            }

            if (startRow > endRow || startCol > endCol)
            {
                Console.WriteLine("Неверно заданы координаты конечной точки.");
                return;
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.Write("\n");
            }
        }

        public void Show()
        {
            ShowPartly(0, 0, matrix.Length, matrix[0].Length);
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                {
                    return matrix[index1][index2];
                }
                Console.WriteLine("Попытка обращения за пределами массива.");
                return 0;
            }
            set
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
}
