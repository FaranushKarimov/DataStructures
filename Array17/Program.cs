using System;

namespace Array17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i <= n - 1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0, j = n - 1; i <= n/4 && j >= n/4; i += 2, j -= 2)
            {
                Console.Write($"{array[i]} {array[i + 1]} {array[j]} {array[j - 1]} ");
            }
        }
    }
}
