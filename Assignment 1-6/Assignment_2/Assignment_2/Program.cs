using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        Console.WriteLine("All items in the list is :");
        List<int> list = new List<int>
        {
            145,36,32,546,2342,5676,535,456,1234,678
        };
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine("\nAll items in ascensing order:");
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine("\nAll items in decending order:");
        list.Reverse();
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine("\nEnter the specific number for searching");
        int x = Convert.ToInt32(Console.ReadLine());     
        Console.WriteLine(list.Contains(x));

        bool ans = list.Contains(x);
        if (ans)
        {
            Console.WriteLine("\nThe list contain " + x);
        }
        else
        {
            Console.WriteLine("\nThe list does not contain " + x);
        }
    }
}