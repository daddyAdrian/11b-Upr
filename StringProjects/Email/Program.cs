using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] details = email.Split('@').ToArray();
            var sumLeftSymbols = SymSymbols(details[0]);
            var sumRightSymbols = SymSymbols(details[1]);
            if (sumRightSymbols - sumLeftSymbols >= 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else
            {
                Console.WriteLine("Call her!");
            }
        }

        private static int SymSymbols(string v)
        {
            var sum = 0;
            for (int i = 0; i < v.Length; i++)
            {
                sum += (int)v[i];
            }
            return sum;
        }
    }
}
