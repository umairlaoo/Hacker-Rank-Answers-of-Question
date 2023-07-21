using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        string s = "";

        for (int j = 1; j <= input; j++)
        {

            s = Console.ReadLine();

            List<char> odd = new List<char>();
            List<char> even = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(s[i]);
                }
                else
                {
                    odd.Add(s[i]);
                }
            }

            //string concatenatedList = string.Join(" ", even.Concat(odd));
            string result = string.Join("", even) + " " + string.Join("", odd);

            Console.WriteLine(result);

        }
    }
}