using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOcc
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int indexOfpattern = text.IndexOf(pattern);

            while (indexOfpattern!=-1)
            {
                counter++;
                indexOfpattern = text.IndexOf(pattern, indexOfpattern+1);
            }
            Console.WriteLine(counter);


        }
    }
}
