using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolledSt
{
    class Enrolled
    {
        public class Student
        {
            public string FN { get; set; }
            public List<int> Marks { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                Student st = new Student();

                string[] data = input.Split();
                st.FN = data[0];
                st.Marks = new List<int>();
                for (int i = 1; i < data.Length; i++)
                    st.Marks.Add(int.Parse(data[i]));

                students.Add(st); //554214,

                input = Console.ReadLine();
            }
                var result = students.
                Where(x => (x.FN[x.FN.Length-1] == '4' || x.FN[x.FN.Length - 1] == '5'));

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(" ", item.Marks));
            }
            
        }
    }
}
