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
    public static List<int> breakingRecords(List<int> scores)
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        var minBreaking = -1;
        var maxBreaking = -1;
        foreach(var score in scores)
        {
            if(min > score)
                { min=score; minBreaking++; }
            if(max < score)
                { max=score; maxBreaking++; }
        }
        var list = new List<int>(){maxBreaking,minBreaking};
        return list;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
        List<int> result = Result.breakingRecords(scores);
        textWriter.WriteLine(String.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}