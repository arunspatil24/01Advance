using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(10,"ten");
            keyValuePairs.Add(9, "nine");
            keyValuePairs.Add(5, "Five");
            keyValuePairs.Add(11, "Eleven");
            foreach (KeyValuePair<int,string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            Console.WriteLine(keyValuePairs.ContainsKey(9));

        }
    }
}