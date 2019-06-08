using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Num = 19;
            Console.WriteLine(d.Num);
        }
    }
    class Demo
    {
        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
    }
}
