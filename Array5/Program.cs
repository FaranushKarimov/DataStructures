using System;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <= 2)
            {
                throw new Exception("Значение n не должно быть меньше или равным 2");
            }
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;
            for(int k = 2; k < array.Length; k++)
            {
                array[k] = array[k - 1] + array[k - 2];
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            }
        }
    }
}
