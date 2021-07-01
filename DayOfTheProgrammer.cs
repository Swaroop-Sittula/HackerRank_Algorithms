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
/* https://www.hackerrank.com/challenges/day-of-the-programmer/problem */
class Result
{
    public static string dayOfProgrammer(int year)
    {
        //256th day of year
        var leap = "12.09.";
        var nonLeap = "13.09.";
        if(year>=1700 && year<=1917)
        { 
            //julian
            if(year%4==0) //leap year
                return leap+year.ToString();
            else
                return nonLeap+year.ToString();
        }
        else if(year>1918)
        {
            //gregorian
            if((year%400==0) || (year%4==0 && year%100!=0))
                return leap+year.ToString();
            else
                return nonLeap+year.ToString();
        }
        else
            return "26.09.1918";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int year = Convert.ToInt32(Console.ReadLine().Trim());
        string result = Result.dayOfProgrammer(year);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
