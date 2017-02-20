using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emails
{
    class email
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            string name = string.Empty;
            string email = string.Empty;
            
            while (command != "stop")
            {
                bool checkIfEmail = command.Contains("@");
                if (!checkIfEmail)
                {
                    name = command;
                    if (!emailBook.ContainsKey(name))
                        emailBook.Add(name, email);
                }
                else
                {
                    email = command;
                    emailBook[name] = email;
                }

                command = Console.ReadLine();
            }

            //foreach (var kvp in emailBook)
            //{
           string pattern1 = ".us";
           string pattern2 = ".uk";
           
            foreach (var kvp in emailBook)
            {
                bool isUS = kvp.Value.Contains(pattern1);
                bool isUK = kvp.Value.Contains(pattern2);
                if (isUK || isUS)
                {
                    emailBook.Remove(kvp.Key);
                    break;
                }
                    
            }
           

            foreach (var kvp in emailBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
