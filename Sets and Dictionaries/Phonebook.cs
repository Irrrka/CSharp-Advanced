using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputInfo = Console.ReadLine().Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            

            while (inputInfo[0] != "search")
            {
                string name = inputInfo[0];
                string number = inputInfo[1];

                if (!phonebook.ContainsKey(name))
                    phonebook.Add(name, number);
                else
                    phonebook[name] = number;
                inputInfo = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string nameToFind = Console.ReadLine();

            while (nameToFind!="stop")
            {
                if (phonebook.ContainsKey(nameToFind))
                    Console.WriteLine($"{nameToFind} -> {phonebook[nameToFind]}");
                else
                    Console.WriteLine($"Contact {nameToFind} does not exist.");
                nameToFind = Console.ReadLine();
            }
        }
    }
}
