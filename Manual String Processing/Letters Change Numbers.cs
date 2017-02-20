using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNum
{
    class LettChangeNum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currChar = input[i];
                char firstchar = currChar[0];
                char lastchar = currChar[currChar.Length-1];
                int number = int.Parse(currChar.Substring(1, currChar.Length - 2));
                int asciiPosition = firstchar % 32;
                if (char.IsLower(firstchar))
                {
                    number *= asciiPosition;
                }
                else
                {
                    number /= asciiPosition;
                }
                asciiPosition = lastchar % 32;
                if (char.IsLower(lastchar))
                {
                    number += asciiPosition;
                }
                else
                {
                    number -= asciiPosition;
                }
                result += number;
            }
            Console.WriteLine("{0:F2}", result);

        }
    }
}
