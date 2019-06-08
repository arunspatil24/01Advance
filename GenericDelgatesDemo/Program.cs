using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelgatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action d1 = delegate ()
            {
                Console.WriteLine("Ankpro");
            };
            d1();

            Action<string> d2 = delegate (string s)
            {
                Console.WriteLine(s);
            };
            d2("Ram");

            Action<int> d3 = delegate (int s)
            {
                Console.WriteLine(s);
            };
            d3(300);


            Func<int, int> f1 = (x) => x * x;
            Console.WriteLine(f1(10));
            Func<int, int, int> f2 = (x, y) => x + y;
            Console.WriteLine(f2(20,30));
            Func<int, int, int, float> f3 = (p, t, r) => (p * t * r) / 100;
            Console.WriteLine(f3(1000,2,2));
            Predicate<int> isEven = (n) => n % 2 == 0;
            Console.WriteLine(isEven(15));
            Predicate<int> isPostive = (n) => n > 0;
            Console.WriteLine(isPostive(15));
        }
    }
}