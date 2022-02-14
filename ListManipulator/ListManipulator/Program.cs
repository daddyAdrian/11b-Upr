using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if(input[0] == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                else if(input[0] == "add")
                {
                    int index = int.Parse(input[1]);
                    nums.Insert(index, int.Parse(input[2]));

                }
                else if(input[0] == "contains")
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(input[1])));
                }
                else if(input[0] == "remove")
                {
                    int index = int.Parse(input[1]);
                    nums.RemoveAt(index);
                }
            }

        }
    }
}
