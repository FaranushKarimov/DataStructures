using System;
using System.Collections.Generic;
using System.Linq;

namespace Array34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = new List<int>();
            var b = new List<int>();
            for(int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 1; i + 1  < n; i++)
            {
                if(a[i] < a[i - 1] && a[i] < a[i + 1])
                {
                    b.Add(a[i]);
                }
            }
            Console.WriteLine(b.Max());
        }
    }
}
