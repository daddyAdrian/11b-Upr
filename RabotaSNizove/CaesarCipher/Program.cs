using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((Char)(input[i] + 3));
            }
            Console.WriteLine(sb);
        }
    }
}
