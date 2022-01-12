using System;

namespace Array14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i <= array.Length-1; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i <= array.Length-1; ++i)
            {
                if(i % 2 == 0)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }
            }
            for(int i = 0; i <= array.Length-1; ++i)
            {
                if(i % 2 != 0)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
