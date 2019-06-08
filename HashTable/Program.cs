using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add(5, "five");
            ht.Add(10, "ten");
            ht.Add(7, "seven");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
           // ht.Add(5,"FIVE");
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
        }
    }
}
