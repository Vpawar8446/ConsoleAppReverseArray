using System;

namespace ConsoleAppReverseArray
{
    class ArrayReverseOrder
    {
        int temp;
        public void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr;
            int num = 0;

            Console.WriteLine("Enter the numbers :");

            num = Convert.ToInt32(Console.ReadLine());
            arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Element [{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            new ArrayReverseOrder().Display(arr);
        }
    }
}

