using System;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <= 1)
            {
                throw new Exception("Значение n не должно быть меньше или равняемым 1");
            }
            int a = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double[] array = new double[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = a * Math.Pow(d,i);
            }
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, array[j]);
            }
        }
    }
}
