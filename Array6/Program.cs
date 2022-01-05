using System;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 2)
            {
                throw new Exception("Значение n не должно быть меньше или равным 2");
            }
            int[] array = new int[n];
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            array[0] = a;
            array[1] = b;
            for(int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            }
        }
    }
}
