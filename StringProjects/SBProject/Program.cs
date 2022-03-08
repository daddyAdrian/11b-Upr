using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SBProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append(str);
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if(input[0] =="Exit")
                {
                    break;
                }
                switch(input[0])
                {
                    case "Append": result.Append(input[1]);
                        break;
                    case "Remove": result.Remove(int.Parse(input[1]), int.Parse(input[2]));
                        break;
                    case "Insert": result.Insert(int.Parse(input[1]), input[2]);
                        break;
                    case "Replace": result.Replace(input[1], input[2]);
                        break;
                    default:break;
                }
                Console.WriteLine(result);
            }
        }
    }
}
