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
/* https://www.hackerrank.com/challenges/bon-appetit/problem */
class Result
{
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        var annaBill = (bill.Sum() - bill[k])/2;
        Console.WriteLine((annaBill==b)?"Bon Appetit": (b-annaBill).toString());
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
