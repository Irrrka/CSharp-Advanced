using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string inputData = Console.ReadLine();//sara mills
        List<string> names = new List<string>();

        while (inputData != "END")
        {
            names.Add(inputData);//sara mills, andrew jhones
            inputData = Console.ReadLine();
        }

                    names.
                    Select(x=>x.Split()).
                    Where(x => x[1].CompareTo(x[0]) ==1).
                    ToList().
                    ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
    }
}

