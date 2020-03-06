using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int temp;

            Console.WriteLine("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
