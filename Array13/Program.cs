using System;

namespace Array13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n % 2 == 0)
            {
                throw new Exception("N должен быть нечетным");
            }
            int[] array = new int[n+1];
            for (int i = 1; i <= n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = n; i >= 1; i -= 2)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
        }
    }
}
