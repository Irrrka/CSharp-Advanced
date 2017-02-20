using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);

            string hec = a.ToString("X");
            string result = "|" + hec.PadRight(10,' ') + "|";
            string binary = Convert.ToString(a,2);
            result += binary.PadLeft(10,'0').Substring(0,10) + "|";
            result += b.ToString("0.00").PadLeft(10, ' ') + "|";
            result += c.ToString("0.000").PadRight(10, ' ') + "|";
            Console.WriteLine(result);



        }
    }
}
