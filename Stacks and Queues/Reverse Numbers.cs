using System;
using System.Collections.Generic;
using System.Linq;



    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stackNum = new Stack<int>();
           
			var numbers = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                stackNum.Push(numbers[i]);
            }
            
            Console.WriteLine(string.Join(" ", stackNum));

        }
    }
