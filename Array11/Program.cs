using System;

namespace Array11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            if(k > n)
            {
                throw new Exception("Значение k не может быть больше n");
            }
            int[] array = new int[n];
            for(int i = 1; i <= array.Length-1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());  
            }
            for(int i = k; i <= array.Length-1; i+=k)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
