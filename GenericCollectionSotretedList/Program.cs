using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionSotretedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(25, "Twenty Five");
            sl.Add(1, "One");
            sl.Add(10, "ten");
            sl.Add(9, "nine");
            sl.Add(-9, "minus nine");
            sl.Add(-3, "minus three");
            foreach (KeyValuePair<int,string> item in sl)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            sl.Remove(25);
            foreach (KeyValuePair<int, string> item in sl)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
