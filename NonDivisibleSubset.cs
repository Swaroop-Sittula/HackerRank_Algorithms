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
/*  https://www.hackerrank.com/challenges/non-divisible-subset/problem  */
class Result
{
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        //remainder count's  => size remains k
        var counts  = new List<int>(Enumerable.Repeat(0, k));
        //List<int> x = Enumerable.Repeat(value, count).ToList();
        foreach(var number in s)
            counts[number%k]++;  //update remainders count
        var count = Math.Min(counts[0], 1); //only one div ele counted
        for(var i=1;i<k/2 + 1;i++)
            if(i!=k-i)
                count += Math.Max(counts[i], counts[k-i]); //take max one, neglect min compliment one
        if(k%2 == 0)
            count++;
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        int result = Result.nonDivisibleSubset(k, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
