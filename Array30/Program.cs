using System;
using System.Collections.Generic;

namespace Array30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a1 = new List<int>();
            var a2 = new List<int>();
            for(int i = 0; i < n; i++)
            {
                a1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 0; i+1<n; i++)
            {
                if(a1[i] > a1[i + 1])
                {
                    a2.Add(i + 1);
                }
            }
            Console.WriteLine(a2.Count);
            foreach (var i in  a2)
            {
                Console.Write(i);
                Console.Write(' ');
            }
        }
    }
}
