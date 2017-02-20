using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string subText = null;
            subText = text.Length > 20 ? text.Substring(0, 20) : text + new string('*', 20 - text.Length);
            Console.WriteLine(subText);



        }
    }
}
