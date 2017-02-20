using System;
using System.Collections.Generic;
using System.Linq;



    public class Program
    {
        public static void Main(string[] args)
        {
			int[] command = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();//3 3 90
			Stack<int> stack = new Stack<int>();
			
			
			int[] elements = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();//90 90 90
			
			foreach (var element in elements)
			{
				stack.Push(element);
			}
			//Console.WriteLine(string.Join(" ", stack));
			
			for (int i=1; i<=command[1]; i++)
				stack.Pop();
			
			//Console.WriteLine(string.Join(" ", stack));
			
			if (stack.Contains(command[2])) Console.WriteLine("true");
			else if(stack.Count!=0)
			{
				int minValue = stack.ToArray().Min();
				Console.WriteLine(minValue);
			}
			else
			{
				Console.WriteLine(0);
			}
        }
    }
