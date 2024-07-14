using Shoping_Portal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_Portal
{
    public class Amazon : IShoppingPortal
    {
        public void Order()
        {
            Console.WriteLine("Ordered from Amazon");
        }
    }
}
