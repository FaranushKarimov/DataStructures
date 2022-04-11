using System;

namespace Array19
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = 10;
            int[] array = new int[n];
            int result = 0;
            for(int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                if(array[i] < array[k] && array[k] < array[n-1])
                {
                    //Console.Write($"{array[i]}");
                    result = array[i];
                    break;
                } 
                
            }
            Console.WriteLine(result);
        }
    }
}
