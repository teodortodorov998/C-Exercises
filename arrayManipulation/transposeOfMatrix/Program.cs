using System;

namespace transposeOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int temp;

            Console.Write("Input number of rows : ");
            int matrixRows = int.Parse(Console.ReadLine());
            Console.Write("Input number of columns: ");
            int matrixColumns = int.Parse(Console.ReadLine());

            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColumns; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            temp = matrix[0, 1];
            matrix[0, 1] = matrix[1,0];
            matrix[1, 0] = temp;

            Console.WriteLine("The transposed matrix is: ");
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColumns; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }

        }
    }
}
