using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyReservation
{
    class PartyReservation
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();//Pesho Misho Slav
            names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, Func<string, string, bool>> predicates = new Dictionary<string, Func<string, string, bool>>
            {
                { "Starts with", (name, substr) => (name.StartsWith(substr))},
                { "Ends with", (name, substr) => (name.EndsWith(substr))},
                { "Length", (name, substr) => (name.Length.ToString().Equals(substr))},
                { "Contains", (name, substr) => (name.Contains(substr)) },
            };
            

            string command;
            var result = new List<string>();

            while ((command=Console.ReadLine()) != "Print")
	        {
                var parameters = Console.ReadLine().Split(';');

                var action = parameters[0];
                var filtertype = parameters[1];
                var filterparam = parameters[2];
                var filter = filtertype + filterparam;
                var filters = new Dictionary<string, string[]>();

                switch (action)
                {
                    case "Add filter":
                        if (!filters.ContainsKey(filter))
                        {
                            filters.Add(filter, new[] { filtertype, filterparam });
                        }
                        break;
                    case "Remove filter":
                        if (!filters.ContainsKey(filter))
                        {
                            filters.Add(filter, new[] { filtertype, filterparam });
                        }
                        break;
                    //case "Print":
                    //    Console.WriteLine();
                    //    return;
                }
                
                foreach (var name in names)
                {
                    bool approved = true;
                    foreach (string[] value in filters.Values)
                    {
                        if (predicates[value[0]](name, value[1]))
                        {
                            approved = false; break;
                        }
                    }
                    if (approved)
                    {
                        result.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
