using System;

namespace matrixEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int flag = 1;


            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill first matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Fill second matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} ", array1[i, j]);
                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Second matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} ", array2[i, j]);

                }
                Console.WriteLine("");
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(array1[i, j] != array2[i, j])
                    {
                        flag = 0;
                        break;
                    }
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("The matrixes are equal.");
            }
            else if(flag == 0)
            {
                Console.WriteLine("Matrixes are not equal.");
            }

        }
    }
}
