using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary <string, Dictionary<string, int>> logsByUser = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {

                string[] logInfo = input.Split();
                string[] IPInfo = logInfo[0].Split('=');
                string IP = IPInfo[1];
                string[] userInfo = logInfo[2].Split('=');
                string user = userInfo[1];

                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(IP, 0);
                }
                else if (!logsByUser[user].ContainsKey(IP))
                {
                    logsByUser[user].Add(IP, 0);
                }
                logsByUser[user][IP]++;

                input = Console.ReadLine();
            }
                foreach (var outerPair in logsByUser)
                {
                    List<string> IpResults = new List<string>();

                    Console.WriteLine($"{outerPair.Key}:");
                    foreach (var innerPair in outerPair.Value)
                    {
                        string result = string.Format("{0} => {1}", innerPair.Key, innerPair.Value);
                        IpResults.Add(result);
                    }
                    Console.Write(string.Join(", ", IpResults));
                    Console.WriteLine(".");
                    
                }
               
        }
    }
}
