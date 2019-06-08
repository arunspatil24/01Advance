using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.City = "Goa";
            // City is a write only property
            // Console.WriteLine(d.City);

            // Phone is a read only property
            // d.Phone = "";
            Console.WriteLine(d.Phone);

            // private set property
            // d.Name = "Ramu";
            Console.WriteLine(d.Name);

            d.IsMarried = true;
            // private get property
            // Console.WriteLine(d.IsMarried);
        }
    }

    class Demo
    {
        private int id;
        private string name;
        private string phone;
        private string city;
        private bool isMarried;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        // Write only property
        public string City
        {
            set { city = value; }
        }

        // read only property
        public string Phone
        {
            get { return phone; }
        }

        // private set property, only members can set the value
        public string Name
        {
            private set { name = value; }
            get { return name; }
        }

        // private get property, only members can get the value
        public bool IsMarried
        {
            set { isMarried = value; }
            private get { return isMarried; }
        }
    }
}