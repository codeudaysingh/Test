
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> Item = new Dictionary<string, double>()
        {
            {"COCACOLA", 95 },
            {"Icecream cone", 50 },
            {"Cake", 150 },
            {"Balloon", 200 },
            {"CupCake", 50 }
        };

        foreach (var item_b in Item)
        {
            Console.WriteLine($" { item_b.Key}: { item_b.Value}");
        }

        Console.WriteLine("\nAverage price of all the product is:");
        Console.WriteLine(Item.Values.Average());


        Console.WriteLine("\nMost Expensive Produvt is:");
        KeyValuePair<string,double> most_expensive = Item.OrderByDescending( x => x.Value ).FirstOrDefault();
        {
            Console.WriteLine($"{most_expensive.Key}:{most_expensive.Value}");
        }

    }
}