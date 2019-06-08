using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo4
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
            var CollestionName = students.Where<Student>(student => student.TotalMarks >= 460);
            foreach (var item in CollestionName)
            {
                Console.WriteLine($"Name {item.Name}\t Branch {item.Branch}\t Marks {item.TotalMarks}");
            }


            Console.WriteLine("Ordering by the TotalMarks");

            var obj = students.OrderBy(student=>student.TotalMarks).ToList();
            foreach (var item in obj)
            {
                Console.WriteLine($"Name {item.Name}\t Branch {item.Branch}\t Marks {item.TotalMarks}");
            }

            Console.WriteLine("Ordering by decsing order the TotalMarks");

            var obj2 = students.OrderByDescending(student => student.TotalMarks).ToList();
            foreach (var item in obj2)
            {
                Console.WriteLine($"Name {item.Name}\t Branch {item.Branch}\t Marks {item.TotalMarks}");
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