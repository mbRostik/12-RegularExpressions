using System;
using System.Text.RegularExpressions;
internal class Program
{
    static void Main()
    {


        string line = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world!Isn’t it great? Well it is :)";

        Regex regex = new Regex(@"\w*[A-Z, a-z]\w[ ](is)[ ]\w*[a-z, A-Z]\w*[a-z, A-Z]\w*[a-z, A-Z]\w*[a-z, A-Z]\W");
        MatchCollection matches = regex.Matches(line);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.ToString());
        }


    }
}
