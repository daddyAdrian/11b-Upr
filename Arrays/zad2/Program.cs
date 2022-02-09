using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command == "END")
                {
                    break;
                }
                switch (command)
                {
                    case "Reverse":
                        arr = arr.Reverse().ToArray();
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(cmd[1]);
                        string newString = cmd[2];
                        if (index >= 0 && index < arr.Length)
                        {
                            arr[index] = newString;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

    }
}