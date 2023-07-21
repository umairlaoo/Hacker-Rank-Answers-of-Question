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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {

        var studentsG = grades.Select(score =>
        {

            if (score > 38 && score < 40)
            {
                return Convert.ToInt32(Math.Round((decimal)score));
            }
            else if(score > 40)
            {
                int nextMultipleOfFive = (score / 5 + 1) * 5;
                int difference = nextMultipleOfFive - score;

                return difference < 3 ? nextMultipleOfFive : score;
                //int R = Convert.ToInt32(Math.Ceiling((decimal)score));
                //if (R - score < 3 && R % 5 == 0)
                //{
                //    return R;
                //}
                //else
                //{
                //    return score;
                //}

            }
            else
            {
                return score;
            }


        }).ToList();
        return studentsG;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        //textWriter.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
