using System;
using System.Text.RegularExpressions;
internal class Program
{
    static void Main()
    {


        string line = "AsssAn Dfv Fov jvhbHgyfvcbhj";
        Regex regex = new Regex(@"[A-Z]\w*[a-z]");
        MatchCollection matches = regex.Matches(line);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.ToString());
        }


    }
}
