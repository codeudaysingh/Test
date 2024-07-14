using Shoping_Portal.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_Portal
{
    public class ShoppingManager 
    {
        public  IShoppingPortal _shoppingPortal;
        
        public ShoppingManager(IShoppingPortal shoppingPortal)
        {
            _shoppingPortal = shoppingPortal;
        }

        public void PlaceOrder()
        {
            _shoppingPortal.Order();
        }
    }
}
