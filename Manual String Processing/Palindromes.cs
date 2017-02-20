using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ',', ' ', '.', '?', '!' };
            string[] text = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            bool isPalindrome = true;
            SortedSet<string> result = new SortedSet<string>();
            int count = 0;


            foreach (var word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    isPalindrome = true;
                    if (word[i]!=word[word.Length-1-i])
                    {
                        isPalindrome = false;
                    }

                }
                if (isPalindrome)
                {
                    count++;
                    result.Add(word);
                }
                count = 0;
            }
            Console.WriteLine("[{0}]", string.Join(",", result));


        }
    }
}
