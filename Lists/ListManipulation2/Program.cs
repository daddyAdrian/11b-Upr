using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if(command=="print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }
                if(int.TryParse(command, out int n) == true)
                {
                    nums.Sort();
                    Console.WriteLine(string.Join(" ", nums));
                }
                switch(command)
                {
                    case "add" : var index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        if (nums.Contains(element) == false) nums.Insert(index, element);
                        break;
                    case "contains": element = int.Parse(input[1]);
                        index = nums.IndexOf(element);
                        break;
                    case "remove":index = int.Parse(input[1]);
                        if (index < 0 || index >= nums.Count) Console.WriteLine("Index is not correct");
                        else nums.RemoveAt(index);
                        break;
                    case "swap": var el1 = int.Parse(input[1]);
                        var el2 = int.Parse(input[2]);
                        var indexEl1 = nums.IndexOf(el1);
                        var indexEl2 = nums.IndexOf(el2);
                        nums[indexEl1] = el2;
                        nums[indexEl2] = el1;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
