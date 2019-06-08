using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student{Id=1,Branch="CSE",Name="Arun",TotalMarks=500},
                new Student{Id=2,Branch="CSE",Name="gur",TotalMarks=450},
                new Student{Id=3,Branch="CSE",Name="Raju",TotalMarks=430},
                new Student{Id=4,Branch="Mech",Name="Sharth",TotalMarks=480},
                new Student{Id=5,Branch="CSE",Name="Rakesh",TotalMarks=580},
                new Student{Id=6,Branch="AutoMech",Name="Rahul",TotalMarks=450},
                new Student{Id=7,Branch="ISE",Name="Ramya",TotalMarks=475},
                new Student{Id=8,Branch="ISE",Name="Celeste",TotalMarks=300}
            };
            var groupByBranch = from student in students
                                group student by student.Branch;
            foreach (var item in groupByBranch)
            {
                    Console.WriteLine(item.Key);
                    foreach (var student in item)
                    {
                            Console.WriteLine($"\t{student.Id}\t{student.Name}\t{student.Branch}\t{student.TotalMarks}");
                    }
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public int TotalMarks { get; set; }
    }
}