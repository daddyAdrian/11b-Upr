using System;
using System.Linq;
using System.Collections.Generic;

namespace NechetniSreshtaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if(counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            List<string> list = new List<string>();
            foreach (var pair in counts)
            {
                if(pair.Value%2!=0)
                {
                    list.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
