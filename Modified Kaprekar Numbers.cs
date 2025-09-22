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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        bool found = false;

        for (long n = p; n <= q; n++)
        {
            long sq = n * n;
            string strSq = sq.ToString();
            int len = strSq.Length;

            string rStr = len > 1 ? strSq.Substring(len - n.ToString().Length) : strSq;
            string lStr = len > rStr.Length ? strSq.Substring(0, len - rStr.Length) : "0";

            long left = long.Parse(lStr);
            long right = long.Parse(rStr);

            if (left + right == n)
            {
                Console.Write(n + " ");
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("INVALID RANGE");
        else
            Console.WriteLine();
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
