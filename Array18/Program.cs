using System;

namespace Array18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            for(int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                if(array[i] < array[n-1])
                {
                    Console.Write($"{array[i]}");
                    break;
                }
            }
        }
    }
}
