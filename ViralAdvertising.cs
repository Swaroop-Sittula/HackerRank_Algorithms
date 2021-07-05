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
 /*  https://www.hackerrank.com/challenges/strange-advertising/problem  */
class Result
{
    public static int viralAdvertising(int n)
    {
        var shared = 5; //==first day initially
        var cummulative = shared/2;
        for(var i=1;i<n;i++)
        {
            shared = (shared/2) * 3;
            cummulative += (shared/2);
        }
        return cummulative;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
