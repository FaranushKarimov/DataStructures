using System;

namespace Array16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];
            for(int i = 0; i <= n - 1; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0, j = n - 1; i < n/2 && j >= n/2; ++i,--j)
            {
                    Console.Write($"{array[i]} {array[j]}  " );
            }
        }
    }
}
