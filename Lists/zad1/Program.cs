using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ') .Select(int.Parse).ToList();
            int first = nums[0];
            while(nums.Contains(first))
            {
                nums.Remove(first);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
