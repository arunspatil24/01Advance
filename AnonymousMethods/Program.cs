using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    delegate int Demo(int a,int b);
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = delegate  (int a,int b)
             {
                 //Console.WriteLine("Anonymous Method Demo");
                 return a + b;

             };
            Console.WriteLine( d(10,20));
        }
    }
}
