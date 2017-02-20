using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> maxNumber = new Stack<int>();
        int maxElement = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int[] command = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int commArg = command[0];

            switch (commArg)
            {
                case 1:
                    int numberToPush = command[1];
                    stack.Push(numberToPush);
                    if (numberToPush >= maxElement)
                    {
                        maxElement = numberToPush;
                        maxNumber.Push(maxElement);
                    }
                    break;
                case 2:
                    int elementAtTop = stack.Pop();
                    int currMaxEl = maxNumber.Peek();
                    if (elementAtTop==currMaxEl)
                    {
                        maxNumber.Pop();
                        if (maxNumber.Count>0)
                        {
                            maxElement = maxNumber.Peek();
                        }
                        else
                        {
                            maxElement = Int32.MinValue;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine(maxNumber.Peek());
                    break;
            }
        }

    }
}
