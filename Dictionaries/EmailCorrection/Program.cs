using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            while(true)
            {
                string name = Console.ReadLine();
                if(name == "stop")
                {
                    break;
                }
                else
                {
                    string email = Console.ReadLine();
                    if(dict.ContainsKey(email))
                    {
                        Console.WriteLine($"E-mail {email} already exists!");
                    }
                    else
                    {
                        dict.Add(email, name);
                    }  
                }
            }
            foreach(var item in dict)
            {
                string[] emailParts = item.Key.Split('.').ToArray();
                string domain = emailParts[emailParts.Length - 1];
                if (domain.ToLower().EndsWith("us"))
                {
                    dict.Remove(item.Key);
                }
            }
            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} - > {item.Value} ");
            }
        }
    }
}
