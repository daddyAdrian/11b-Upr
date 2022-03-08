using System;
using System.Text;

namespace Cenzura
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            sb.Replace(word, new string('*', word.Length));
            Console.WriteLine(sb);
        }
    }
}
