using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Sawpping a = {a} and b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swapping a = {a} and b = {b} ");

            string str1 = "Arun";
            string str2 = "Kiran";
            Console.WriteLine($"Before Swapping str1 ={str1} and str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"After Swapping str1 = {str1} and str2 = {str2}");

        }
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}