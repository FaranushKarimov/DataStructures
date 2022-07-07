using System;
using System.Collections.Generic;

namespace Array32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a1 = new List<int>();
            int min = 1000000000;
            for(int i = 0; i < n; i++)
            {
                a1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 1; i+1 < n; i++)
            {
                if(a1[i] < a1[i - 1] && a1[i] < a1[i+1])
                {
                    min = a1[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
