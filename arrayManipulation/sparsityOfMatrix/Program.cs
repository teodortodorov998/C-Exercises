using System;

namespace sparsityOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];


            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int zeroElementsCount = 0;
            int numberOfElements = 0;
            double sparsity = 0.0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                    numberOfElements++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                    {
                        zeroElementsCount++;
                    }
                }
            }

            sparsity = (double)zeroElementsCount / (double)numberOfElements;
            

            if (sparsity > 0.5)
            {
                Console.WriteLine("The given matrix is sparse matrix.");
                Console.WriteLine($"There are {zeroElementsCount} number of zeros in the matrix.");
            }
            else
            {
                Console.WriteLine("The given matrix is dense.");
            }

        }
    }
}
