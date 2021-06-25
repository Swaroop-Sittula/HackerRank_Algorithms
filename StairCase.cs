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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for(var i=1;i<=n;i++)
        {
            //Console.WriteLine(new String(' ',n-i) + new String('#',i));
            //Console.WriteLine(new String('#', i ).PadLeft(n-i, ' '));
           for(var j=1;j<=n-i;j++)
               Console.Write(' ');
           for(var j=1;j<=i;j++)
               Console.Write('#');
           Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
