using System;

namespace Algorithms
{
    class Program
    {
        static int[] Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int buf = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buf;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            array = Sort(array);
            for(int i = 0; i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
