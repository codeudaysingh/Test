
class Program
{
    static void Main(String[] args)
    {
        List<string> fruits = new List<string>
        {
            "Mango",
            "Banana",
            "graps",
            "Strawbarry",
            "Apple"
        };

        Console.WriteLine("List of Fruits is:");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        fruits.Add("barries");
        Console.WriteLine("\nHere is the new list:");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        fruits.RemoveAt(1);
        Console.WriteLine("\nAfter removing second item form the list");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        Console.WriteLine("\nThe third item in the list is: " + fruits[2]);
        Console.WriteLine("\nChecking weather the list contain Apple or not:");
        
        Console.WriteLine(fruits.Contains("Apple"));
        Console.WriteLine("\nFinal item in the list is:");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine(fruits[i]);
        }

    }

}
