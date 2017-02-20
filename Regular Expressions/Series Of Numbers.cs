using System;
using System.Text.RegularExpressions;

namespace SeriesOfNumbers
{
    class SeriesOfNumbers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//aaaaabbbbbcdddeeeedssaa
            string pattern = @"(.)\1+";
            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}
