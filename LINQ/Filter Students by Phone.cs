using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortByPhone
{
    class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phones { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                Student st = new Student();

                st.FirstName = input.Split()[0];
                st.LastName = input.Split()[1];
                st.Phones = input.Split()[2];

                students.Add(st);

                input = Console.ReadLine();
            }

            students.
                Where(x => x.Phones.StartsWith("02") || x.Phones.StartsWith("+3592")).
                ToList().
                ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName}"));
        }
    }
}
