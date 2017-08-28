using System;

namespace _01Matrix
{
	public class Solution
	{
		public int[,] UpdateMatrix(int[,] matrix)
		{
			if (matrix == null)
			{
				return null;
			}

			if (matrix.Rank == 2)
			{

				var rowNumber = matrix.GetLength(0);
				var columNumer = matrix.GetLength(1);

				for (int i = 0; i < rowNumber; i++)
				{
					for (int j = 0; j < columNumer; j++)
					{
						if (matrix[i, j] != 0)
						{
							matrix[i, j] = GetDistence(matrix, i, j);
						}
					}
				}
			}

			return matrix;
		}

		private int GetDistence(int[,] matrix, int rowIndex, int columnIndex)
		{
			var hitted = false;
			var distence = 0;
			var rowNumber = matrix.GetLength(0);
			var columNumer = matrix.GetLength(1);

			while (!hitted)
			{
				distence++;
				hitted = Hitted(matrix, rowIndex, columnIndex, distence);
				if (distence > (rowNumber > columNumer ? rowNumber : columNumer))
				{
					return -1;
				}
			}

			return distence;
		}

		private bool Hitted(int[,] matrix, int rowIndex, int columnIndex, int distence)
		{
			var rowNumber = matrix.GetLength(0);
			var columNumer = matrix.GetLength(1);

			for (int i = 0 - distence; i <= distence; i++)
			{
				var currentColumnIndex = columnIndex + i;
				var currentPositiveRowIndex = rowIndex + (distence - Math.Abs(i));
				var currentNegtiveRowIndex = rowIndex - (distence - Math.Abs(i));
				if (currentColumnIndex >= 0
					&& currentColumnIndex < columNumer)
				{
					if (currentPositiveRowIndex >= 0
						&& currentPositiveRowIndex < rowNumber)
					{
						if (matrix[currentPositiveRowIndex, currentColumnIndex] == 0)
						{
							return true;
						}
					}

					if (currentPositiveRowIndex != currentNegtiveRowIndex
						&& currentNegtiveRowIndex >= 0
						&& currentNegtiveRowIndex < rowNumber)
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
