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

using System.Numerics;
/*  https://www.hackerrank.com/challenges/extra-long-factorials/problem */
class Result
{

    public static void extraLongFactorials(int n)
    {
        BigInteger big = new BigInteger(1);
        foreach(var i in Enumerable.Range(1, n))
            big *= i;
        Console.WriteLine(big);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}
