using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"<a\shref=\W((\W|\w)*)\W>\s?(.*)\s?<\/a>";

        string action = "<ul>\n  <li>\n    <a href=http://softuni.bg>SoftUni </a>\n  </li>\n</ul>";

        Regex regex = new(pattern);

        string cleanString = regex.Replace(action, "[URL href=$1 $3[/URL]");

        Console.WriteLine(cleanString);


        Console.ReadKey();
    }
}