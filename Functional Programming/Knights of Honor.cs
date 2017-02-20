using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            //Action<string> print = text => Console.WriteLine(text);
            //foreach (var name in names)
            //    print(name);
            Action<string> sirprnt = knight => Console.WriteLine("Sir " + knight);
            foreach (var name in names)
                sirprnt(name);
        }
    }
}
