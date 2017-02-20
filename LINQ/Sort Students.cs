using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudent
{
    class SortSt
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int FN { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public int Group { get; set; }
            public double Grade1 { get; set; }
            public double Grade2 { get; set; }
            public double Grade3 { get; set; }
            public double Grade4 { get; set; }
            public string Phones { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input!="END")
            {
                Student st = new Student();
                st.FirstName = input.Split()[0];
                st.LastName = input.Split()[1];

                students.Add(st);
                input = Console.ReadLine();
            }

            //var result =
                students.OrderBy(x => x.LastName).
                ThenByDescending(x =>x.FirstName).
                ToList().
                ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
        }
    }
}
