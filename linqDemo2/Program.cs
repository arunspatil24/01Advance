using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student{Id=1,Age=25,Name="Arun",TotalMarks=500},
                new Student{Id=2,Age=24,Name="gur",TotalMarks=450},
                new Student{Id=3,Age=23,Name="Raju",TotalMarks=430},
                new Student{Id=4,Age=23,Name="Sharth",TotalMarks=480},
                new Student{Id=5,Age=24,Name="Rakesh",TotalMarks=580}

            };

            var MoreThen460 = from student in students
                              where student.TotalMarks >= 460
                            //  where student.Age>=24
                              select student;
            //Deffered Execucation
            students.Add(new Student() { Id=6,Age=23,TotalMarks=490,Name="Rantha"});
            Console.WriteLine("Id\tName\tTotalMarks");
            foreach (var item in MoreThen460)
            {
                Console.WriteLine(item.Id+"\t"+item.Name+"\t"+item.TotalMarks);
            }
           //Imeditae Execution
            var moreThen460Count= (from student in students
                                  where student.TotalMarks >= 460
                                  //  where student.Age>=24
                                  select student).Count();

            //this statment is not inculded in the collection because the queure is exetued imeditally
            students.Add(new Student() { Id = 7, Age = 25, TotalMarks = 520, Name = "Radha" });

            Console.WriteLine("The Total number of count who scored more then 460 are "+moreThen460Count);

            IEnumerable<Student> orderByMarks = from student in students
                                                orderby student.TotalMarks
                                                select student;

            Console.WriteLine("Id\tName\tTotalMarks");
            foreach (var item in orderByMarks)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.TotalMarks);
            }

            IEnumerable<Student> orderByMarksDec = from student in students
                                                orderby student.TotalMarks descending
                                                select student;

            Console.WriteLine("Id\tName\tTotalMarks");
            foreach (var item in orderByMarksDec)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.TotalMarks);
            }
            Console.WriteLine();
            var obj = new { Name = "Ram", Age = 20 };
            Console.WriteLine($"Name : {obj.Name} and age is {obj.Age}");
            Console.WriteLine();

            var onlyNameTotalMarks = from student in students
                                     select new {Name=student.Name,TotalMarks=student.TotalMarks};
            Console.WriteLine();
            Console.WriteLine("Id\tName\tTotalMarks");
            foreach (var item in onlyNameTotalMarks)
            {
                Console.WriteLine( item.Name + "\t" + item.TotalMarks);
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
    }
}