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
            int[] nm = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int n = nm[0];
            int m = nm[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                set1.Add(num1);
            }
            for (int i = 0; i < m; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                set2.Add(num2);
            }
            var print1 = set1.Intersect(set2).ToArray();
           // var print2 = set1.Union(set2).ToArray();

            Console.WriteLine(string.Join(" ", print1));
            //Console.WriteLine(string.Join(" ", print2));
            
        }
    }
}
