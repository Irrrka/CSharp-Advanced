using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStringOcc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, char> mappedChard = new Dictionary<char, char>();
            string shorterstr = input[0];
            string longerstr = input[1];

            if (shorterstr.Length>longerstr.Length)
            {
                var temp = shorterstr;
                shorterstr = longerstr;
                longerstr = temp;
            }

            bool magic = true;
            for (int i = 0; i < shorterstr.Length; i++)
            {
                if (!mappedChard.ContainsKey(longerstr[i]))
                {
                    mappedChard.Add(longerstr[i], shorterstr[i]);
                }
                else if (mappedChard[longerstr[i]]!=shorterstr[i])
                {
                    magic = false;
                }
            }
            if (magic)
            {
                for (int i = shorterstr.Length; i < longerstr.Length; i++)
                {
                    if (!mappedChard.ContainsKey(longerstr[i]))
                    {
                        magic = false;
                        break;
                    }
                }
            }
            Console.WriteLine(magic.ToString().ToLower());


        }
    }
}
