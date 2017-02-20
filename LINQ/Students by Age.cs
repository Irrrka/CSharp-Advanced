using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsbyAge
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName {get; set;}
        public int FN { get; set; }
        public string Email {get;set;}
        public int Age { get; set; }
        public int Group { get; set; }
        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
        public double Grade3 { get; set; }
        public double Grade4 { get; set; }
        public string Phones { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (inputData!="END")
            {
                Student newStudent = new Student();

                newStudent.FirstName = inputData.Split()[0];
                newStudent.LastName = inputData.Split()[1];
                newStudent.Age= int.Parse(inputData.Split()[2]);

                students.Add(newStudent);

                inputData = Console.ReadLine();
            }

            //var result =
                students.Where(x => (x.Age >= 18 && x.Age <= 24)).
                ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " " + x.Age));
        }
    }
}
