using System;

namespace secondLargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            int[,] array2 = new int[5, 5];
            int[,] array3 = new int[5, 5];
            int sum;

            Console.Write("Enter array1 rows: ");
            int arrayRows1 = int.Parse(Console.ReadLine());
            Console.Write("Enter array1 columns: ");
            int arrayColumns1 = int.Parse(Console.ReadLine());

            Console.Write("Enter array2 rows: ");
            int arrayRows2 = int.Parse(Console.ReadLine());
            Console.Write("Enter array2 columns: ");
            int arrayColumns2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayRows1; i++)
            {
                for (int j = 0; j < arrayColumns1; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < arrayRows2; i++)
            {
                for (int j = 0; j < arrayColumns2; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }

            }

            if (arrayColumns1 != arrayRows2)
            {
                Console.WriteLine("Mutiplication of Matrix is not possible.");
                Console.WriteLine("Column of first matrix and row of second matrix must be same.");
            }
            else
            {

                for (int i = 0; i < arrayRows1; i++)
                {
                    for (int j = 0; j < arrayColumns2; j++)
                    {
                        sum = 0;
                        for (int k = 0; k < arrayColumns1; k++)
                        {

                            sum += array1[i, k] * array2[k, j];


                        }
                        array3[i, j] = sum;
                    }
                }




                Console.Write("The result array of the multiplied arrays is: ");
                for (int i = 0; i < arrayRows1; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < arrayColumns2; j++)
                    {
                        Console.Write($"{array3[i, j]} ");
                    }

                }

            }

            
        }
    }
}
