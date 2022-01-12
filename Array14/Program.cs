using System;

namespace Array14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];
            for(int i = 1; i <= n; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 2; i <= n; i += 2)
            {
                    Console.Write(array[i]);
                    Console.Write(" ");
                
            }
            for(int i = 1; i <= n; i += 2)
            {
                    Console.Write(array[i]);
                    Console.Write(" ");
        
            }
        }
    }
}
