using System;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string line = "aaaaabbbbbcdddeeeedssaa";

        string mask = @"(\w)\1+";


        Regex regex = new(mask);
        line = regex.Replace(line,"$1");

        Console.WriteLine(line);
    }
}
