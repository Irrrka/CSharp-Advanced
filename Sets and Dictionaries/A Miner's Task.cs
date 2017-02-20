using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minercollect
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();//gold
            int quantity;
            Dictionary<string, long> resourses = new Dictionary<string, long>();
            string resourse = string.Empty;

            while (command != "stop")
            {
                bool isString = int.TryParse(command, out quantity);//true
                
                if (!isString)
                {
                    resourse = command;//gold
                    if (!resourses.ContainsKey(resourse))
                    {
                        resourses.Add(resourse, quantity);//gold,0
                    }
                }
                else
                {
                    quantity = int.Parse(command);
                    resourses[resourse] += quantity;
                }

                command = Console.ReadLine();//155
            }

            foreach (var kvp in resourses)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
