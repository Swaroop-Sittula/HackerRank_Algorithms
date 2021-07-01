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
/* https://www.hackerrank.com/challenges/migratory-birds/problem */
class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        //sorted in ascending order, so we can get small bird with max count
        var countTypes = arr.GroupBy(c => c).OrderBy(c => c.Key);
        var maxCount = 0;
        var typeId = 0;
        foreach(var pair in countTypes)
        {
            if(maxCount < pair.Count())
            {
                maxCount = pair.Count();
                typeId = pair.Key;
            }
        }
        return typeId;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int result = Result.migratoryBirds(arr);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
