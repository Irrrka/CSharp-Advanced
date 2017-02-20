using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> character = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!character.ContainsKey(item))
                    character.Add(item,1);
                else
                    character[item]++;
            }
            foreach (var kvp in character)
                Console.WriteLine("{0}: {1} time/s", kvp.Key, kvp.Value);
        }
    }
}
