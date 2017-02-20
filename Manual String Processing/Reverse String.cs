using System;
using System.Text;

  class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = ReverseString(name);
            Console.WriteLine(result);
        }
    
        public static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }

