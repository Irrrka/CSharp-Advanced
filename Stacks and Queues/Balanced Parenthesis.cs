using System;
using System.Collections.Generic;

namespace Parentheses
{
    class Program
    {
        static void Main()
        {
            //{[()]}
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool balanced = false;

            for (int i = 0; i < input.Length; i++)
            {
                char parenth = input[i];
                switch (input[i])
                {
                    case '{':
                        parentheses.Push(parenth);
                        break;
                    case '}':
                        if (parentheses.Count!=0 && parentheses.Peek() == '{')
                        {
                            parentheses.Pop();
                            balanced = true;
                        }
                        else
                            balanced = false;
                        break;
                    case '[':
                        parentheses.Push(parenth);
                        break;
                    case ']':
                        if (parentheses.Count != 0 && parentheses.Peek() == '[')
                        {
                            parentheses.Pop();
                            balanced = true;
                        }
                        else
                            balanced = false;
                        break;
                    case '(':
                        parentheses.Push(parenth);
                        break;
                    case ')':
                        if (parentheses.Count != 0 && parentheses.Peek() == '(')
                        {
                            parentheses.Pop();
                            balanced = true;
                        }
                        else
                            balanced = false;
                        break;
                    default:
                        break;
                }
            }
            if (balanced)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
