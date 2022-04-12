using System;

namespace Array20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = k - 1; i < l; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
