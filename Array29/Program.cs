using System;
using System.Collections.Generic;

namespace Array29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = new List<int>();
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 0; i < n; i += 2)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
