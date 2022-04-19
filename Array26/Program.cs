using System;
using System.Collections.Generic;

namespace Array26
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
            bool D = a[0] % 2 == 0 && a[1] % 2 == 1;
            for (int i = 1; i < n; i+=2)
            {
                if((a[i-1] % 2 == 0 && a[i] % 2 == 1) != D)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
        }
    }
}
