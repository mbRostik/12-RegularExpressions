using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] action = Console.ReadLine().Split(' ');
        for (int i = 0; i < action.Length; i++)
            if (Regex.IsMatch(action[i], @"\w*[A-Z, a-z]\w(@)\w*[a-z, A-Z]\w[.]\w*[a-z, A-Z]"))
                Console.WriteLine(action[i]);
    }
}



