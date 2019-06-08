using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo3
{
    delegate void Example();
    class Program
    {
        public static void Show()
        {
            Console.WriteLine("Static Show Method from same class");
        }
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Example e = new Example(d.Print);
            e += d.OutPut;
            e += Demo.Display;
            e += Show;
            e += d.OutPut;
            e -= Demo.Display;
            e -= d.OutPut;
            e();
        }
    }
    class Demo
    {
       public void Print()
        {
            Console.WriteLine("Print Method from other class");
        }
        public void OutPut()
        {
            Console.WriteLine("OutPut Method from other class");
        }
        public static void Display()
        {
            Console.WriteLine("Display Static Method from other class");
        }
    }
}