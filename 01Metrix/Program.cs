using System;

namespace _01Matrix
{
    class Program
    {
        static int NUMBER = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("input is:");
            var matrix = GenerateTestMatrix(NUMBER);

            var solution = new Solution();
            var updateMatrix = solution.UpdateMatrix(matrix);

            Console.WriteLine("output is");

            for (int i = 0; i < NUMBER; i++)
            {
                for (int j = 0; j < NUMBER; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

        }

        private static int[,] GenerateTestMatrix(int number)
        {
            var matrix = new int[number, number];
            var radom = new Random();

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    matrix[i, j] = radom.Next(2);

                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            return matrix;
        }
    }
}
