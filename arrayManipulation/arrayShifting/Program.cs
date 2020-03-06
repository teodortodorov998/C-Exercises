using System;

namespace arrayShifting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];


            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Write the new value position: ");
            int position = int.Parse(Console.ReadLine());

            arr[position] = arr[size + 1];

            for (int i = position; i <= size; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.Write("The array with the new value is: ");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
