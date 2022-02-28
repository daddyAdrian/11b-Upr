using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imeil1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if(input[0] == "Stop")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    if(emails.ContainsKey(input[1]))
                    {
                        emails[input[1]] = input[2];
                    }
                    else
                    {
                        emails.Add(input[1], input[2]);
                    }
                }
                else if(input[0] == "Sent")
                {
                    if(emails.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} {emails[input[1]]}");
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
