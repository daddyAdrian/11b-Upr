using System;
using System.Linq;
using System.Collections.Generic;

namespace TelUkazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "A")
                {
                    if(ukazatel.ContainsKey(input[1]))
                    {
                        ukazatel[input[1]] = input[2];
                    }
                    else
                    {
                        ukazatel.Add(input[1], input[2]);
                    }
                }
                else if(input[0] == "S")
                {
                    if(ukazatel.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {ukazatel[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
            }
        }
    }
}
