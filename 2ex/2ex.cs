using System;
using System.Text.RegularExpressions;
internal class Program
{
    static void Main()
    {

        Regex regex = new Regex(@"[+][3][5][9][ ][2][ ]\d{3}[ ]\d{4}");
        Regex regex2 = new Regex(@"[+][3][5][9]-[2]-\d{3}-\d{4}");
        while (true)
        {
            string line = Console.ReadLine();
            if(line == "END")
            {
                break;
            }
            MatchCollection matches = regex.Matches(line);

            MatchCollection matches2 = regex2.Matches(line);

            foreach (Match match in matches)
            {
                Console.WriteLine();
                Console.WriteLine(match.ToString());
            }
            foreach (Match match in matches2)
            {
                Console.WriteLine();
                Console.WriteLine(match.ToString());
            }
        }
    }
}
