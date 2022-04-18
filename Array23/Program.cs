using System;

namespace Array23
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
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < k - 1; i++)
            {
                sum += array[i];
                count++;
            }
            for(int i = l; i < n; i++)
            {
                sum += array[i];
                count++;
            }
            Console.WriteLine(sum / count);
        }
    }
}
