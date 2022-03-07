using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
