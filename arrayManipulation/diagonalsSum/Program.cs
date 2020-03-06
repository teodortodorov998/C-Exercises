using System;

namespace diagonalsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n, m = 0;
            int[,] array = new int[5, 5];
            Console.WriteLine("Enter the rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the columns: ");
            int c = int.Parse(Console.ReadLine());

            m = r;

            Console.WriteLine("Input elements int the matrix: ");
            for ( i = 0; i < r; i++)
            {
                for ( j = 0; j < c; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("The matrix is :\n");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }

            for ( i = 0; i < r; i++)
            {
                m = m - 1;
                for ( j = 0; j < c; j++)
                {
                    if(j == m)
                    {
                        sum = sum + array[i, j];
                    }
                }
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
