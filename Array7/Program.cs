using System;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for(int j = array.Length - 1; j >= 0; j--)
            {
                Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            }
        }
    }
}
