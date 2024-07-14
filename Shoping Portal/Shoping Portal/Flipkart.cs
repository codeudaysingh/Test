using Shoping_Portal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_Portal
{
     class Flipkart : IShoppingPortal
    {
        public void Order()
        {
            Console.WriteLine("Ordered from Flipkart");
        }
    }
}
