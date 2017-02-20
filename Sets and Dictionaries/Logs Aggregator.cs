using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            
           SortedDictionary<string, long> durationByUser = 
                new SortedDictionary<string, long>(); //user,duration, ip
            Dictionary<string, List<string>> IPofUsers = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine(); //192.168.0.11 peter 33

                string[] logInfo = input.Split(); //192.168.0.11/peter/33
                string user = logInfo[1]; //peter
                string IP = logInfo[0]; //192.168.0.11
                long duration = long.Parse(logInfo[2]); //33

                if (!durationByUser.ContainsKey(user))
                        durationByUser.Add(user, 0); //peter, 33
                durationByUser[user] += duration;

                if (!(IPofUsers.ContainsKey(user)))
                    IPofUsers.Add(user, new List<string>());
                
                if (!(IPofUsers[user].Contains(IP)))
                    IPofUsers[user].Add(IP);

            }
            foreach (var kvp in durationByUser)
            {
                IPofUsers[kvp.Key].Sort();
                Console.WriteLine("{0}: {1} [{2}]", kvp.Key, kvp.Value, string.Join(", ", IPofUsers[kvp.Key]));
            }
        }
    }
}
