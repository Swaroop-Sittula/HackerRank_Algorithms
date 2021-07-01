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
/* https://www.hackerrank.com/challenges/the-birthday-bar/problem */
class Result
{
    public static int birthday(List<int> s, int d, int m)
    {
        //m - size of subarray
        //d - sum value of 'm' consecutive values
        var result = 0;
        
        var windowSum = s.Take(m).Sum();
        //s.Skip(i).Take(m).Sum() ... costly for window sum in for loop (since returns a list)
        //we can also use s.GetRange(i,m).Sum()
        
        if(windowSum == d)
            result++;
        
        for(var i=0;i<s.Count-m;i++)
        {
            windowSum += (s[i+m] - s[i]);
            if(windowSum == d)
                result++;
        }
        
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int d = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);
        int result = Result.birthday(s, d, m);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
