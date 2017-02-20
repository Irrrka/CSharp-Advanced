using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Group { get; set; }
        }
        static void Main(string[] args)
        {
            //Ivaylo Petrov 10
            string input = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (input!= "END")
            {
                string[] data = input.Split();

                Person person = new Person();
                person.Name = data[0] + " " + data[1];
                person.Group = int.Parse(data[2]);
                persons.Add(person);

                input = Console.ReadLine();

            }

            var result = persons.OrderBy(x => x.Group).
                GroupBy(gr => gr.Group).
                ToList();
            foreach (var group in result)
            {
                Console.Write(group.Key + " - ");
                List<string> list = new List<string>();
                foreach (var person in group)
                {
                    list.Add(person.Name);
                }
                Console.WriteLine(string.Join(", ", list));

            }
        }
    }
}
