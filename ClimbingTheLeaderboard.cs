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
 /*  https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem  */
class Result
{
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        ranked = ranked.Distinct().ToList();
        var ranks = new List<int>();
        var lastIndex = ranked.Count-1;
        for(var i=0;i<player.Count;i++)
        {
            for(var j=lastIndex;j>=0;j--)
            {
                if(player[i] < ranked[j])
                {
                    ranks.Add(j+2); //prev rank + 1
                    lastIndex = j;
                    break;
                }
                else if(j==0)
                    ranks.Add(1);
            }
        }
        return ranks;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
