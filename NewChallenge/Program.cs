using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int j = 0;
        double k = 0.0;
        string s1 = "";
        // Read and save an integer, double, and String to your variables.
        j = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToDouble(Console.ReadLine());
        s1 = Console.ReadLine().ToString();
        int sum = i + j;
        double db = d + k;

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(sum);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(db.ToString("N1"));
        // Concatenate and print the String variables on a new line
        string s2 = s + s1;
        // The 's' variable above should be printed first.
        Console.WriteLine(s2);
    }
}