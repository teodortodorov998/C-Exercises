using System;

namespace sumOfRowsAndColumns
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
            int m = 0;
            int[] sumOfRow = new int[5];
            int[] sumOfColumn = new int[5];

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
                {
                    sumOfRow[i] += array[i, j];
                   
                }
            }

            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    
                        sumOfColumn[i] += array[j, i];
                    
                }
                
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"The sum of row{i} is: {sumOfRow[i]}");
            }
            Console.WriteLine("");
            for (int i = 0; i < columns; i++)
            {
                Console.WriteLine($"The sum of column{i} is: {sumOfColumn[i]}");
            }

        }
    }
}
