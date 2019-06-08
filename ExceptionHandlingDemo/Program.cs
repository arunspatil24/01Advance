using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2] { 10, 20 };
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                    throw new Exception();
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("We are in index out of range exception");
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("We are in divideByZero Exception error");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    Console.WriteLine("Finally block ");
                }

            }
            
        }
    }
}

