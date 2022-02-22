using System;
using System.Collections.Generic;
using System.Linq;

namespace minior
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input != "stop")
                {
                    int input1 = int.Parse(Console.ReadLine());
                    if (dict.ContainsKey(input))
                    {
                        dict[input] = dict[input] + input1;
                    }
                    else
                    {
                        dict.Add(input, input1);
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, int> kvp in dict)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                    break;
                }
            }
        }
    }
}
