using System;
using System.Collections.Generic;
using System.Linq;


namespace OfficeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //●	| SoftUni - 600 - paper |
            //●	| Vivacom - 600 - pen |
            //●	| XS - 20 - chair |
            //●	| Vivacom - 200 - chair |
            //●	| SoftUni - 40 - chair |
            //●	| XS - 40 - chair |
            //●	| SoftUni - 1 - printer |

            //●	SoftUni: paper - 600, chair - 40, printer - 1
            //●	Vivacom: pen - 600, chair - 200
            //●	XS: chair - 60

            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, Dictionary<string, int>> resultList = 
                new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                FillCollection(input, resultList);
            }

            Print(resultList);
        }

        public static void Print(SortedDictionary<string, Dictionary<string, int>> resultList)
        {
            foreach (var kvp in resultList)
            {
                List<string> result = new List<string>();
                Console.Write(kvp.Key + ": ");


                result.AddRange(kvp.Value.Select(subpair => (subpair.Key + "-" + subpair.Value)));
                Console.WriteLine(string.Join(", ", result));
                result.Clear();
            }
        }

        public static void FillCollection(string input, SortedDictionary<string, Dictionary<string, int>> resultList)
        {
            string[] data = input.Split(new char[]{ ' ', '|', '-'}, StringSplitOptions.RemoveEmptyEntries);
            string company = data[0];
            int amount = int.Parse(data[1]);
            string product = data[2];

            if (!resultList.ContainsKey(company))
            {
                resultList.Add(company, new Dictionary<string, int>());
                resultList[company].Add(product, 0);
            }
            else if(!resultList[company].ContainsKey(product))
            {
                resultList[company].Add(product, 0);
            }
            resultList[company][product] += amount;
        }
    }
}
