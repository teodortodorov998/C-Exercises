using System;

namespace rightDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] arr1 = new int[50, 50];


            

            Console.Write("Input the rows: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the columns:");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }


            Console.Write("The matrix is :\n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n", sum);
        }
    }
}
