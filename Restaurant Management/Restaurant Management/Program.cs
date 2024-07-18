using Restaurant_Management;

class Program
{

    public static void Main()
    {
        Restaurant_M restaurant = new Restaurant_M();

        restaurant.AddMenuItem(new Food("Pizza", 71.72));
        restaurant.AddMenuItem(new Food("Burger", 89.99));
        restaurant.AddMenuItem(new Food("Coke", 90));
        restaurant.AddMenuItem(new Food("Coffee", 45.79));

        restaurant.DisplayMenu();

        restaurant.RemoveMenuItem("Burger");

        restaurant.DisplayMenu();

        List<string> order = new List<string> { "Pizza", "Coke" };
        double totalCost = restaurant.CalculateTotalCost(order);
        Console.WriteLine($"\nTotal cost of the order: {totalCost}");
    }
}