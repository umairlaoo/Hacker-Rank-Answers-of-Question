using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        List<int> zero = new List<int>();
        int len = arr.Count;
        for (int i = 0; i < len; i++)
        {
            if (arr[i] > 0)
            {
                positive.Add(arr[i]);
            }
            else if (arr[i] < 0)
            {
                negative.Add(arr[i]);
            }
            else if (arr[i] == 0)
            {
                zero.Add(arr[i]);
            }
        }
        double pos = Convert.ToDouble(positive.Count) / Convert.ToDouble(len);
        double neg = Convert.ToDouble(negative.Count) / Convert.ToDouble(len);
        double zr = Convert.ToDouble(zero.Count) / Convert.ToDouble(len);
        string pos_p = pos.ToString("N6");
        string neg_p = neg.ToString("N6");
        string zr_p = zr.ToString("N6");
        Console.WriteLine(pos_p);
        Console.WriteLine(neg_p);
        Console.WriteLine(zr_p);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
