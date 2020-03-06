using System;

namespace identityMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[10, 10];
            
            

            


            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    if((i == j && array1[i, j] != 1) || (i != j && array1[i, j] != 0))
                    {
                        goto label;
                    }
                }
            }

            Console.WriteLine("The matrix is an identity matrix.");
            return;

            label:
            Console.WriteLine("The matrix is not an identity matrix.");
               

        }
    }
}
