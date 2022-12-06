using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
internal class Program
{
    static void Main()
    {


        string line = Console.ReadLine();
        Regex regex = new Regex(@"[A-Z, a-z, 1-9]\w*[a-z, A-Z, 1-9]");
        MatchCollection matches = regex.Matches(line);
        List<string> names=new List<string>();
        foreach (Match match in matches)
        {
            string temp = "";
            temp += match;
            temp= Regex.Replace(temp, @"\s+", String.Empty);
            names.Add(temp);
        }

        for (int i = 0; i < names.Count - 1; i++)
        {
            for (int j = i + 1; j < names.Count; j++)
            {
                if (names[i].Length < names[j].Length)
                {
                    string temp = names[i];
                    names[i] = names[j];
                    names[j] = temp;
                }
            }
        }

        for (int i = 0; i < 2; i++)
            Console.WriteLine(names[i]);


    }
}
