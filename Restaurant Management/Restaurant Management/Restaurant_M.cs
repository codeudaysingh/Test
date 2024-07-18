using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    public class Restaurant_M
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public void AddMenuItem(MenuItem item)
        {
            menuItems.Add(item);
            Console.WriteLine($"{item.Name} added to the menu.");
        }

        public void RemoveMenuItem(string name)
        {
            MenuItem itemToRemove = menuItems.Find(item => item.Name == name);
            if (itemToRemove != null)
            {
                menuItems.Remove(itemToRemove);
                Console.WriteLine($"\n{name} removed from the menu.");
            }
            else
            {
                Console.WriteLine($"\n{name} not found in the menu.");
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (var item in menuItems)
            {
                item.Display();
            }
        }

        public double CalculateTotalCost(List<string> order)
        {
            double totalCost = 0;
            foreach (var itemName in order)
            {
                MenuItem item = menuItems.Find(i => i.Name == itemName);
                if (item != null)
                {
                    totalCost += item.Price;
                }
            }
            return totalCost;
        }
    }
}
