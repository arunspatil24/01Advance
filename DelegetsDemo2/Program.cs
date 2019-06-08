using System;

namespace DelegetsDemo2
{
    delegate void Demo();
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Demo d = new Demo(c.GetRadius);
            // d();

            d += c.ShowArea;
            d();
        }
    }
    class Circle
    {
        private int radius;
        public void GetRadius()
        {
            Console.WriteLine("Enter the Radius");
            radius = int.Parse(Console.ReadLine());
        }
        public void ShowArea()
        {
            float area = 3.14f * radius * radius;
            Console.WriteLine($"The area of the Circle is {area}");
        }
    }
}