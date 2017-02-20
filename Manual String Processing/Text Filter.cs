using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedword = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string result = String.Empty;

            foreach (var word in bannedword)
            {
                result = text.Replace(word, new string('*', word.Length));
                text = result;
            }
            Console.WriteLine(result);


        }
    }
}
