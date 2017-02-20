using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellSt
{
    class byGrades
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<double> Marks { get; set; }
   
        }
        static void Main()
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                Student st = new Student();

                st.FirstName = input.Split()[0];
                st.LastName = input.Split()[1];
                st.Marks = new List<double>();
                for (int i = 2; i < input.Split().Length; i++)
                    st.Marks.Add(int.Parse(input.Split()[i]));


                students.Add(st);

                input = Console.ReadLine();
            }

            students.Where(x => x.Marks.Contains(6)).
                Select(x=> $"{ x.FirstName} { x.LastName}").
                ToList().
                ForEach(x => Console.WriteLine(x));
        }
    }
}
