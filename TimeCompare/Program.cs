using System;
using System.Diagnostics;

namespace TimeCompare
{
    class Program
    {
        const int n = 10000;

        static void Main(string[] args)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next() % 500;
            Timing objT = new Timing();
            Stopwatch stpWatch = new Stopwatch();
            objT.StartTime();
            stpWatch.Start();
            stpWatch.Stop();
            objT.StopTime();
            Console.WriteLine("StopWatch " + stpWatch.Elapsed.ToString());
            Console.WriteLine("Timing " + objT.Result().ToString());
            Console.ReadLine();
        }
    }
}
