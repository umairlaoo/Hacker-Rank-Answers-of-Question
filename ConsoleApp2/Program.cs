using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Result
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        List<BigInteger> Sumofall = new List<BigInteger>();
        BigInteger sum = 0;

        // Calculate the sum of all elements in the array
        foreach (var i in arr)
        {
            sum += i;
        }

        // Calculate the sum of all elements except the current element and store them in a list
        foreach (var i in arr)
        {
            Sumofall.Add(sum - i);
        }

        // Find the minimum and maximum sums from the list
        BigInteger min = Sumofall.Min();
        BigInteger max = Sumofall.Max();

        Console.WriteLine(min + " " + max);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
