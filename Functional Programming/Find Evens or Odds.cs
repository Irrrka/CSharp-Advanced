using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            Predicate<int> filter = n => n % 2 == 0;

            if (command=="odd")
            {
                filter = n => n % 2 == 1;
            }

            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (filter(Math.Abs(i)))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
