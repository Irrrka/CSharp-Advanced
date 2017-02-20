using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> fibonacc = new Stack<long>();
            fibonacc.Push(1);
            fibonacc.Push(1);
            if (n != 0 && n != 1)
            {
                for (int i = 2; i < n; i++)
                {
                    long n1 = fibonacc.Pop();
                    long n2 = fibonacc.Peek();
                    long sum = n1 + n2;
                    fibonacc.Push(n1);
                    fibonacc.Push(sum);
                }
                Console.WriteLine(fibonacc.Peek());
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
