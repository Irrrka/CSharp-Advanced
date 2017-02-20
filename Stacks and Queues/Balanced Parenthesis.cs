using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            //{[()]}

            bool isBalanced = false;

            if (parentheses.Length % 2 == 0)
            {
                Stack<char> left = new Stack<char>();
                Queue<char> right = new Queue<char>();

                for (int i = 0; i < parentheses.Length; i++)
                {
                    left.Push(parentheses[i]); //{[()]}
                    right.Enqueue(parentheses[i]); //{[()]}
                }
 	           while (right.Count > parentheses.Length / 2)
                {
                    char currPerentheseinStack = left.Pop();
                    char currParentheseinQueue = right.Dequeue();
                    if (currPerentheseinStack == currParentheseinQueue+2 || currPerentheseinStack == currParentheseinQueue - 2)
                        isBalanced = true;
                    else if (currPerentheseinStack == currParentheseinQueue + 1 || currPerentheseinStack == currParentheseinQueue - 1)
                        isBalanced = true;
                }
                if (isBalanced)
                    Console.WriteLine("YES");
            }

            else Console.WriteLine("NO");
            
        }
    }
}
