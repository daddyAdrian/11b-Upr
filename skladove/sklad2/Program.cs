using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rechnik = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input != "end")
                {
                    int input1 = int.Parse(Console.ReadLine());
                    if(rechnik.ContainsKey(input))
                    {
                        rechnik[input] = input1;
                        Console.WriteLine($"Product {input} has changed it's quantity");
                    }
                    else
                    {
                        rechnik.Add(input, input1);
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, int> kvp in rechnik)
                    {
                        if(kvp.Key.StartsWith("t"))
                            {
                            rechnik.Remove(kvp.Key);
                            }
                        else
                        {
                            Console.WriteLine("{0} - > {1}", kvp.Value, kvp.Key);
                        }
                    }
                    break;
                }
            }
        }
    }
}
