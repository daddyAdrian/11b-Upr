using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sklad = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if(input[0] == "end")
                {
                    break;
                }
                if(sklad.ContainsKey(input[0]))
                {
                    Console.WriteLine($"Product {input[0]} has changed its quantity!");
                    sklad[input[0]] += int.Parse(input[1]);
                }
                else
                {
                    sklad.Add(input[0], int.Parse(input[1]));
                }

            }
            foreach (var item in sklad)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
