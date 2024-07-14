using Shoping_Portal;
using Shoping_Portal.Contract;
using System;

namespace Shoping_Portal
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            string portal = "Amazon"; 

            IShoppingPortal shoppingPortal;

            if (portal == "Amazon")
            {
                shoppingPortal = new Amazon();
            }
            else if (portal == "Flipkart")
            {
                shoppingPortal = new Flipkart();
            }
            else
            {
                throw new Exception("Invalid shopping portal");
            }

            ShoppingManager manager = new ShoppingManager(shoppingPortal);
            manager.PlaceOrder();
        }
    }
}