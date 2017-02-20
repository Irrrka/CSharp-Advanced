using System;
using System.Collections.Generic;
using System.Linq;


namespace PopulationCounter
{
    class Population
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> populationByCitybyCountry = 
                new Dictionary<string, Dictionary<string, long>>();//country, city, int
                                                                                                                                      
            long totalPopulation = 0;

            while (input != "report")
            {
                string[] data = input.Split('|');
                string city = data[0];
                string country = data[1];
                long population = long.Parse(data[2]);
               

                if (!populationByCitybyCountry.ContainsKey(country))
                    populationByCitybyCountry.Add(country, new Dictionary<string, long>());
                populationByCitybyCountry[country].Add(city, population);
                //else if (!populationByCitybyCountry[country].ContainsKey(city))
                //{
                //    populationByCitybyCountry[country].Add(city, population);
                //}
                input = Console.ReadLine();
            }

                foreach (var outerPair in populationByCitybyCountry.OrderByDescending(x => x.Value.Sum(y => y.Value)))
                {
                    totalPopulation = 0;
                    foreach (var innerPair in outerPair.Value)
                        {
                            totalPopulation += innerPair.Value;
                        }
                        Console.WriteLine("{0} (total population: {1})", outerPair.Key, totalPopulation);//country
                
                    foreach (var innerPair in outerPair.Value.OrderByDescending(x=>x.Value))//city
                        {
                            Console.WriteLine("=>{0}: {1}", innerPair.Key, innerPair.Value);
                        }
                }
        }
    }
}
