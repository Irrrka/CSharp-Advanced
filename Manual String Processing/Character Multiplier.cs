using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            //Gosho Pesho

            string str1 = input[0];//Gosho
            string str2 = input[1];//Pesho
            long sum = SumChar(str1, str2);
            Console.WriteLine(sum);
        }
        public static long SumChar(string str1, string str2)
        {
            long sum = 0;
            if (str1.Length<str2.Length)
            {
                str1 = str1.PadRight(str2.Length, '0');
            }
            if (str1.Length > str2.Length)
            {
                str2 = str2.PadRight(str1.Length, '0');
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i]!=0 || str2[i] != 0)
                {
                    sum += (long)(str1[i] * str2[i]);
                }
                else
                {
                    sum += (str1[i] + str2[i]);
                }
            }


            return sum;
        }
    }
}
