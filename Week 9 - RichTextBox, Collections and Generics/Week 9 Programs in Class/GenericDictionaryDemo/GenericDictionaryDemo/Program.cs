using System;
using System.Collections.Generic;

namespace GenericDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> weekdays = new Dictionary<int, string>();

            // Add values
            weekdays.Add(1, "Monday");
            weekdays.Add(2, "Tuesday");
            weekdays.Add(3, "Wednesday");
            weekdays.Add(4, "Thursday");
            weekdays.Add(5, "Friday");
            weekdays.Add(6, "Saturday");
            weekdays.Add(7, "Sunday");

            // Total entries in the dictionary
            Console.WriteLine("There are {0} items in the dictionary currently", weekdays.Count);

            // Check of an particular value
            if (weekdays.ContainsValue("Friday"))
            {
                Console.WriteLine("\nFriday is the last week day!");
                weekdays.Remove(6);
                weekdays.Remove(7);
            }

            // Display the dictionary entries
            foreach (KeyValuePair<int, string> items in weekdays)
            {
                Console.WriteLine("Key: {0}, Value: {1}", items.Key, items.Value);
            }

            // Accessing individual elements
            Console.WriteLine("\nThe First day is " + weekdays[1]);

            Console.ReadKey();
        }
    }
}
