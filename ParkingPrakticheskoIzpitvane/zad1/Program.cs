using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vhod = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int unsuccessful = 0;
            for (int i = 0; i < vhod; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if(input[0] == "register")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                        unsuccessful = unsuccessful + 1;
                    }
                    else
                        {
                            dict.Add(input[1], input[2]);
                            Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                        }
                }
                else if(input[0] == "unregister")
                {
                    if(dict.ContainsKey(input[1]))
                    {
                        dict.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                        unsuccessful = unsuccessful + 1;
                    }
                }
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - > {item.Value} ");
            }
            Console.WriteLine($"unsuccessfully - > {unsuccessful}");
        }
    }
}
