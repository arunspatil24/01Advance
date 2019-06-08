using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10,20,5,3,-2,-5,-6,-8,-10};
            Console.WriteLine("All Numbers");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            var q = from n in arr
                    where n >= 0
                    where n%2==0
                    select n;
            Console.WriteLine("Postive numbers are :-------");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
