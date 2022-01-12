using System;

namespace Array15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];
            for(int i = 1; i <= array.Length - 1; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i <= array.Length - 1; i += 2)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            for(int i = n - Convert.ToInt32(array[n] % 2 != 0); i >= 1; i -= 2)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
