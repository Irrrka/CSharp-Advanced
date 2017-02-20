using System;
using System.Collections.Generic;
using System.Linq;



    public class Program
    {
        public static void Main(string[] args)
        {
			int[] command = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();//3 3 90
			Queue<int> queue = new Queue<int>();
			
			
			int[] elements = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();//90 90 90
			
			foreach (var element in elements)
			{
				queue.Enqueue(element);
			}
			//Console.WriteLine(string.Join(" ", queue));
			
			for (int i=1; i<=command[1]; i++)
			{
			
				queue.Dequeue();
			}
			
			//Console.WriteLine(string.Join(" ", queue));
			
			if (queue.Contains(command[2])) Console.WriteLine("true");
			else if (queue.Count!=0)
			{
				int minValue = queue.ToArray().Min();
				Console.WriteLine(minValue);
			}
			else
			{
				Console.WriteLine(0);
			}

        }
    }
