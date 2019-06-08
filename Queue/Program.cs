using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qe = new Queue();
            qe.Enqueue(100);
            qe.Enqueue("Arun");
            foreach (var item in qe)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(qe.Count);
            Console.WriteLine(qe.Peek());
        }
    }
}
