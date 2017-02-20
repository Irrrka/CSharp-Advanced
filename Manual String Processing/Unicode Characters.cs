using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                result.Append("\\u");
                result.Append(String.Format("{0:x4}", (int)text[i]));
            }
            Console.WriteLine(result);
        }
    }
}
