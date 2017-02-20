using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            bool isObtained = false;
            Dictionary<string, int> quantityOfItems = new Dictionary<string, int>();
            SortedDictionary<string, int> quantityOfJunks= new SortedDictionary<string, int>();
            

            quantityOfItems.Add("shards", 0);
            quantityOfItems.Add("fragments", 0);
            quantityOfItems.Add("motes", 0);

            while (!isObtained)
            {
                string input = Console.ReadLine().ToLower();//3 motes 5 stones 248 motes
                string[] inputArg = input.Split();
                for (int i = 0; i < inputArg.Length; i += 2)
                {

                    int quantity = int.Parse(inputArg[i]);
                    string material = inputArg[i + 1];

                    bool isNotJunk = material == "shards" || material == "fragments" || material == "motes";

                    if (isNotJunk)
                    {
                        if (quantityOfItems.ContainsKey(material))
                        {
                            quantityOfItems[material] += quantity;
                            if (quantityOfItems[material] >= 250)
                            {
                                quantityOfItems[material] -= 250;
                                isObtained = true;
                                WhoIsObrained(material);
                                break;
                            }
                        }

                    }
                    else if (!isNotJunk)
                    {
                        if (!(quantityOfJunks.ContainsKey(material)))
                            quantityOfJunks.Add(material, 0);
                               quantityOfJunks[material] += quantity;
                    }
                }
            }
            PrintResourses(quantityOfItems);
            PrintJunks(quantityOfJunks);

        }


        private static void PrintJunks(SortedDictionary<string, int> quantityOfJunks)
        {
            foreach (var kvp in quantityOfJunks)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }

        private static void PrintResourses(Dictionary<string, int> quantityOfItems)
        {
            foreach (var kvp in quantityOfItems.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }

        private static void WhoIsObrained(string materials)
        {
            switch (materials)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }
        }
    }
}
