using System;

namespace Parentheses
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long FibbNumber = getFibonacci(n);
            Console.WriteLine(FibbNumber);
        }

        private static long getFibonacci(long n)
        {
            if (n==1 || n==2)
            {
                return 1;
            }
            else
            {
                return getFibonacci(n - 1) + getFibonacci(n - 2);
            }
        }
    }
}
