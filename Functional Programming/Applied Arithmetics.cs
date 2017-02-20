using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        public static class Function
        {
            public static void Print(List<int> collection, Action<List<int>> act)
            {
                act(collection);
            }
            public static List<int> ApplyFunc(List<int> collection, Func<int, int> func)
            {
                List<int> result = new List<int>();
                foreach (var item in collection)
                    result.Add(func(item));
                return result;
            }
        }
        
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!="end")
            {
                switch (command)
                {
                    case"add":
                        numbers = Function.ApplyFunc(numbers, x => x + 1);
                        break;
                    case "subtract":
                        numbers = Function.ApplyFunc(numbers, x => x - 1);
                        break;
                    case "multiply":
                        numbers = Function.ApplyFunc(numbers, x => x * 2);
                        break;
                    case "print":
                        Function.Print(numbers, x => Console.WriteLine(string.Join(" ", numbers)));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }


        }
    }
}
