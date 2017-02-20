using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Irina Marina
            string fullName = Console.ReadLine();

            while (fullName!="end")
            {
                string pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+";
                Regex regex = new Regex(pattern);
                bool containsText = regex.IsMatch(fullName);
                if (containsText)
                {
                    Console.WriteLine(fullName);
                }

                fullName = Console.ReadLine();
            }

        }
    }
}
