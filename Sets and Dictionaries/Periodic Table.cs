using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Dict1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//4

            HashSet<string> chem = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();//Ma Na
                for (int j = 0; j < input.Length; j++)
                {
                    chem.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", chem));
        }
    }
}
