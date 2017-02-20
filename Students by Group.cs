using System;
using System.Collections.Generic;
using System.Linq;


public class Student
{
    static void Main()
    {
        //Sara Mills 1
        string inputData = Console.ReadLine();
        List<string> names = new List<string>();
        
        while (inputData!= "END")
        {
            names.Add(inputData);//Sara Mills 1, Andrew Gibson 2
            inputData = Console.ReadLine();
        }

        var groupSt = names.
                    Select(x => x.Split()).
                    Where(x => x.Contains("2")).
                    OrderBy(x => x[0]);
        foreach (var item in groupSt)
        {
            Console.WriteLine(item[0] + " " + item[1]);
        }

    }
}
