using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseExclude
{
    class ReverseExclude
    {
        static void Main(string[] args)

        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            int div = int.Parse(Console.ReadLine());

            //Func<int, bool> divisible = i => numbers[i] % div != 0;
            //Func<int, int> reverse = i => numbers[numbers.Count - i-1];

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (!(numbers[i] % div != 0))
                {
                    numbers.RemoveAt(i);
                }
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
