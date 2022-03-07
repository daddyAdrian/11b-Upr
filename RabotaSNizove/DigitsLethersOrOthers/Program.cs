using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DigitsLethersOrOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder chisla = new StringBuilder();
            StringBuilder bukvi = new StringBuilder();
            StringBuilder characters = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    chisla.Append(input[i]);
                }
                else if(Char.IsLetter(input[i]))
                {
                    bukvi.Append(input[i]);
                }
                else
                {
                    characters.Append(input[i]);
                }
            }
            Console.WriteLine(string.Join("", chisla));
            Console.WriteLine(string.Join("", bukvi));
            Console.WriteLine(string.Join("", characters));
        }
    }
}
