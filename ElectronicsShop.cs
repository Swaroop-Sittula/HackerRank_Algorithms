using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*  https://www.hackerrank.com/challenges/electronics-shop/problem */
class Solution {

    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        var maxPurchase = -1;
        foreach(var keyboard in keyboards)
        {
            foreach(var drive in drives)
            {
                if(keyboard+drive <= b && maxPurchase<keyboard+drive)
                    maxPurchase = keyboard + drive;
            }
        }
        return maxPurchase;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
