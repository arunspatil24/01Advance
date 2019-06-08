using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabdaExpression
{
    delegate int Add(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            //Add fun = delegate (int n1, int n2)
            //  {
            //      return n1 + n2;
            //  };
             Add fun = (int n1, int n2) => { return n1 + n2; };
            //Add fun = (n1, n2) => { return n1 + n2; };
            //Add fun = (n1, n2) => n1 + n2;
            Console.WriteLine(fun(20,20));
        }
    }
}