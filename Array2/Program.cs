using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length ; i++)
            {
                array[i] = 2 * i + 2;
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            }
        }
    }
}
