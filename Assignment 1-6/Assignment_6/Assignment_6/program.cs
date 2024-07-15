using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Program 

    {
        static void Main (string[] args)
        {
            Dictionary<Person, string> ps_info = new Dictionary<Person, string>();

            Person person1 = new Person("Uday Singh", "Yadav");
            Person person2 = new Person("John", "Whik");
            Person person3 = new Person("Shelendra", "Sharma");

            ps_info.Add(person1, "udays@gmal.com");
            ps_info.Add(person2, "john@gmal.com");
            ps_info.Add(person3, "shelen@gmal.com");

            Console.WriteLine("Contact Details");
            foreach (var eml in ps_info)
            {
                Console.WriteLine($"{eml.Key.FirstName} {eml.Key.LastName}: {eml.Value}");
            }

            Console.WriteLine("\nUpdated Contact Details");
            ps_info[person3] = "Shelendra@gmail.com";
            foreach (var eml in ps_info)
            {
                Console.WriteLine($"{eml.Key.FirstName} {eml.Key.LastName}: {eml.Value}");
            }

            Console.WriteLine("\nUpdated Contact Details");
            ps_info.Remove(person2);
            foreach (var eml in ps_info)
            {
                Console.WriteLine($"{eml.Key.FirstName} {eml.Key.LastName}: {eml.Value}");
            }

        }
    }
}
