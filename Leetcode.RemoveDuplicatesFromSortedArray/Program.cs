using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.RemoveDuplicatesFromSortedArray
{
   
    class Program
    {
        public static int[] RemoveDuplicates(int[] nums)
        {
            //int[] array = new int[nums.Length];
            var array = nums.Distinct().ToArray();
            //for (int i = 0; i < nums.Length; ++i)
            //{
            //    if (nums[i] != nums[i + 1])
            //    {
            //        array.Add(nums[i]);
            //    }
            //}
            return array;
        }
        static void Main(string[] args)
        {
            var a = RemoveDuplicates(new int[] { 1, 2, 1 });
            Console.WriteLine("Hello World!");
        }
    }
}
