using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo<int, string> d1 = new Demo<int, string>(10, "Arun");
            d1.Display();

            Demo<float, char> d2 = new Demo<float, char>(12.56f, 'b');
            d2.Display();
        }
    }

    class Demo<T, U>
    {
        private T t;
        private U u;

        public Demo(T _t,U _u)
        {
            t = _t;
            u = _u;
        }
        public void Display()
        {
            Console.WriteLine($"t={t}\t u={u}");
        }
    }
}
