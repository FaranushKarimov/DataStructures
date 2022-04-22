using System;
using System.Collections.Generic;

namespace Array27
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
            bool D = a[0] > 0 && a[1] < 0;
            for(int i = 1; i < n; i += 2)
            {
                if((a[i-1] > 0 && a[i] < 0) != D)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
        }
    }
}
