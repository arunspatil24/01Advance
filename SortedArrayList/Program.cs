using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(17, "Davanagere");
            s1.Add(16,"Chitradurga");
            s1.Add(09, "Mysore");
            s1.Add(04, "Bangalore");
            s1.Add(19, "Mangalore");

            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            s1.Remove(16);
            Console.WriteLine("\n");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine(s1.Contains(4));
            Console.WriteLine(s1.ContainsValue("Hubli"));
            s1.RemoveAt(2);
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
