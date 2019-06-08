using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("The count of the array list is "+arrayList.Count);
            arrayList.Add(10);
            arrayList.Add("Ram");
            arrayList.Add(true);
            arrayList.Add(13.0f);
            arrayList.Add(20202);
            arrayList.Add('a');
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            arrayList.Remove("Ram");
            arrayList.Insert(2, "Arun");
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            ArrayList li = new ArrayList() { 10, 20, true, "Hello", "Ankpro", 'a' };
            Console.WriteLine("The count of the array list is " + li.Count);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            arrayList.AddRange(li);
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.InsertRange(2, li);
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(3);
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveRange(2, 5);
            Console.WriteLine("The count of the array list is " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains("Arun"));
            Console.WriteLine(arrayList.Contains(1000));
            ArrayList l3=arrayList.GetRange(2, 3);
            Console.WriteLine("The count of the array list is " + l3.Count);
            foreach (var item in l3)
            {
                Console.WriteLine(item);
            }

        }
    }
}