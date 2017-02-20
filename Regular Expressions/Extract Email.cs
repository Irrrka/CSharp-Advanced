using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//Please contact us at: support@github.com.

            string pattern = @"([a-z0-9]+([_.-][a-z0-9]+)*@([a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text);

            foreach (Match email in matches)
            {
                Console.WriteLine($"{email.Groups[1]}");
            }
        }
    }
}
