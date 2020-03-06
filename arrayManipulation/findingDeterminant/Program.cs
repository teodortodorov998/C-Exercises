using System;

namespace findingDeterminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] array = new int[10, 10];
            int det = 0;

            Console.WriteLine("Enter elements of the array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("The matrix is :\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}  ", array[i, j]);
                Console.Write("\n");
            }

            for (int i = 0; i < 3; i++)
                det = det + (array[0, i] * (array[1, (i + 1) % 3] * array[2, (i + 2) % 3] - array[1, (i + 2) % 3] * array[2, (i + 1) % 3]));

            Console.Write("\nThe Determinant of the matrix is: {0}\n\n", det);

        }
    }
}
