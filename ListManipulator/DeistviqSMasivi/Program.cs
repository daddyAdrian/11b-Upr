using System;
using System.Linq;
using System.Collections.Generic;

namespace DeistviqSMasivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int count = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if(arr[i] > 5)
                {
                    count++;
                }
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("count =" + count);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("Average" + arr.Average());
        }
    }
}
