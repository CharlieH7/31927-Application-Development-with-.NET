using System;
using System.Collections;

namespace Week9ClassProgram
{
    class HasTableDemo
    {
        static void Main(string[] args)
        {
            // Creating a HashTable
            Hashtable weekDays = new Hashtable();

            // Adding values as Key value pair
            weekDays.Add("1", "Monday");
            weekDays.Add("2", "Tuesday");
            weekDays.Add("3", "Wednesday");
            weekDays.Add("4", "Thusday");
            weekDays.Add("5", "Friday");
            weekDays.Add("6", "Saturday");
            weekDays.Add("7", "Sunday");
            
            // Check is a specific value is present
            if (weekDays.ContainsValue("Friday"))
            {
                Console.WriteLine("Friday is the last weekday!, Happy Weekend!");
                weekDays.Remove("6");
                weekDays.Remove("7");
            }

            // Retiving the values and dsiplaying
            // Get the collection of keys
            ICollection keys = weekDays.Keys;
            Console.WriteLine("\nThe Weekdays are:");
            foreach(string key in keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, weekDays[key]);
            }

            Console.ReadKey();
        }
    }
}
