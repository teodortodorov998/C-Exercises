using System;

namespace lowerTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] array = new int[5, 5];
            

            Console.WriteLine("Enter elements of the array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0}  ", array[i, j]);
                Console.Write("\n");
            }

            Console.Write("\nSetting zero in lower triangular matrix\n");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                {
                    
                    if (i <= j)
                    {
                        Console.Write("{0}  ", array[i, j]);
                    }
                    else
                    {
                        Console.Write("{0}  ", 0);
                    }
                }
            }




        }
    }
}
