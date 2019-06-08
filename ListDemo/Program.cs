using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(30);
            numbers.Remove(30);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers.Count);
            numbers.Add(50);
            numbers.Add(-30);
            numbers.RemoveAll(n=>n<=0);
            
            Console.WriteLine(numbers.Count);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
