using System;

namespace Array8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 != 0)
                {
                    count++;
                    Console.WriteLine(array[i] + " ");
                }
            }
            Console.WriteLine(count);

        }
    }
}
