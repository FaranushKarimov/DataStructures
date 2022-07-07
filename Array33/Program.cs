using System;
using System.Collections.Generic;

namespace Array33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a1 = new List<int>();
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                a1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 1; i + 1 < n; i++)
            {
                if(a1[i - 1] < a1[i] && a1[i+1] < a1[i])
                {
                    max = a1[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
