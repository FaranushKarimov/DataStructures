using System;
using System.Collections.Generic;

namespace Array24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = new List<int>();
            for(int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int D = a[1] - a[0];
            for(int i = 1; i < n; i++)
            {
                int d = a[i] - a[i - 1];
                if(d != D)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine(D);
        }
    }
}
