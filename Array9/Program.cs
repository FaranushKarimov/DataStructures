using System;

namespace Array9
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
            }
            for(int j = array.Length - 1; j >= 0; j--)
            {
                if(array[j] % 2 == 0)
                {
                    count++;
                    Console.Write(array[j] + " ");
                }
            }
            Console.WriteLine("Количество четных чисел " + count);
        }
    }
}
