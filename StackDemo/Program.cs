using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('a');
            st.Push(123);
            st.Push("arun");
            Console.WriteLine(st.Count);
            Console.WriteLine(st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st.Pop());
            Console.WriteLine("After Pop");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
