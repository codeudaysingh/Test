using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant_Management
{
    public class Food : MenuItem
    {
     

        public Food(string name, double price) : base(name, price) { }


        public override void Display()
        {
            Console.WriteLine($"Food: {Name}, Price: {Price}");
        }

    }
}
