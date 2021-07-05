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
/*  https://www.hackerrank.com/challenges/utopian-tree/problem  */
class Result
{
    public static int utopianTree(int n)
    {
        var height = 1; //at start
        //better for updates, if one of the condition changes
        for(int i=1;i<=n;i++)
        {
            if(i%2==0)
                height++;
            else
                height *= 2;
        }
        return height;
        //var height = 2 * ((int)Math.Pow(2,(n+1)/2) - 1);
        //return (n%2==0)?height+1:height;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
