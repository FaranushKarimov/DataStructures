using System;

namespace Array12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 != 0)
            {
                throw new Exception("N должен быть чётным");
            }
            int[] array = new int[n];
            for(int i = 0; i <= array.Length-1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 2; i <= array.Length-1; i+=2)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
        }
    }
}
