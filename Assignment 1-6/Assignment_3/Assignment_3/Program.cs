using System.Data;

class Progrma
{
    static void Main()
    {
        Dictionary<string, int> record = new Dictionary<string, int>()
        {
            {"Uday",95},
            {"Ajay",78 },
            {"John",98 },
            {"Sheru",67 },
            {"Kohli",88 }
        };

        Console.WriteLine("\nStudent Score Record:");

        foreach (var student in record)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        record["John"] = 00;
        Console.WriteLine("\nUpdated score:");
        foreach (var student in record)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        record.Remove("Kohli");
        Console.WriteLine("\nAfter removing Kohli:");
        foreach (var student in record)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }
    }

}