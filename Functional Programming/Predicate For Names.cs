using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class PredNames
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();//Kurnelia Qnaki Geo Muk Ivan
            names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<int, string, bool> getNameLenght = NameLenght;

            names.Where(i => getNameLenght(lenght, i)).
                Select(nm => nm).ToList().ForEach(nm => Console.WriteLine(nm));
                
            
        }
        private static bool NameLenght(int n, string name)
        { 
            return name.Length <= n ? true : false;
        }
    }
}
