using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Matrix
{
    public class Solution
    {
        public int[,] UpdateMatrix(int[,] matrix)
        {
            var number = Math.Sqrt(matrix.Length);

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    if (matrix[i, j] != 0)
                    {
                        matrix[i, j] = GetDistence(matrix, i, j);
                    }
                }
            }

            return matrix;
        }

        private int GetDistence(int[,] matrix, int rowIndex, int columnIndex)
        {
            var hitted = false;
            var distence = 0;

            while (!hitted)
            {
                distence++;
                hitted = Hitted(matrix, rowIndex, columnIndex, distence);
            }

            return distence;
        }

        private bool Hitted(int[,] matrix, int rowIndex, int columnIndex, int distence)
        {
            var number = Math.Sqrt(matrix.Length);
            for (int i = 0 - distence; i <= distence; i++)
            {
                var currentColumnIndex = columnIndex + i;
                var currentPositiveRowIndex = rowIndex + (distence - Math.Abs(i));
                var currentNegtiveRowIndex = rowIndex - (distence - Math.Abs(i));
                if (currentColumnIndex >= 0
                    && currentColumnIndex <= number - 1)
                {
                    if (currentPositiveRowIndex >= 0
                        && currentPositiveRowIndex <= number - 1)
                    {
                        if (matrix[currentPositiveRowIndex, currentColumnIndex] == 0)
                        {
                            return true;
                        }
                    }

                    if (currentPositiveRowIndex != currentNegtiveRowIndex
                        && currentNegtiveRowIndex >= 0
                        && currentNegtiveRowIndex <= number - 1)
                    {
                        if (matrix[currentNegtiveRowIndex, currentColumnIndex] == 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }


}
