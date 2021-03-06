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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double[] ratios = {0,0,0};
        foreach(var num in arr)
        {
            //(num==0)?ratios[2]+=1:( (num>0)?ratios[0]+=1:ratios[1]+=1);
            //error CS0201
            if(num==0)
                ratios[2]++;
            else if(num>0)
                 ratios[0]++;
            else   
                 ratios[1]++;
            
        }
        foreach(var ratio in ratios)
            Console.WriteLine(String.Format("{0:0.000000}",ratio/arr.Count));
        //"{index:N6}" also works
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
