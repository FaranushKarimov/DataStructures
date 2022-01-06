using System;

namespace Array10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for(int j = 0, i = n-1; j < array.Length || i >= 0;)
            //{
            //    if(array[j] % 2 == 0)
            //    {
            //        j++;
            //    }
            //    else
            //    {

            //    }
            //}
            Console.WriteLine("Четные числа");
            for (int j = 0; j < array.Length; j++)
                if(array[j] % 2 == 0)
                    Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            Console.WriteLine("\nНечетные числа");
            for (int i = array.Length-1; i >= 0; i--)
                if(array[i] % 2 != 0)
                    Console.WriteLine("Element[{0}] = {1}", i, array[i]);
        }
    }
}
