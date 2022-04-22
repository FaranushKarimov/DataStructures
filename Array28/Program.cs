using System;
using System.Collections.Generic;

namespace Array28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = new List<int>();
            int min = 100000000;
            for(int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 1; i < n; i += 2)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
