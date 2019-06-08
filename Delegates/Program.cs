using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Calculator(int a, int b);
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculator c = new Calculator(Add);
            Console.WriteLine("Addtion Method result is");
            Console.WriteLine(c(10, 20));
            c = Sub;
            Console.WriteLine("Subraction Method result is");
            Console.WriteLine(c(10, 20));
            c = Multiply;
            Console.WriteLine("Multiplcation Method result is");
            Console.WriteLine(c(10,20));
        }

        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Sub(int a,int b)
        {
            return a - b;
        }
        public static int Multiply(int a,int b)
        {
            return a * b;
        }
    }
}
