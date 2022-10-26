using System;
using System.Collections.Generic;


namespace Week9CallProgram
{
    class LinkeListDemo
    {
        static void Main(string[] args)
        {
            // Create a LinkedList
            LinkedList<string> weekdays = new LinkedList<string>();
            
            // Add data into the list
            weekdays.AddFirst("Monday");
            weekdays.AddLast("Saturday");

            // Add "Tuesday" after "Monday"
            LinkedListNode<string> current = weekdays.Find("Monday");
            weekdays.AddAfter(current, "Tuesday");

            current = weekdays.Find("Saturday");
            weekdays.AddAfter(current, "Sunday");
            weekdays.AddBefore(current, "Friday");

            // Display items in LinkedList
            foreach (string items in weekdays)
            {
                Console.WriteLine(items);
            }

            Console.ReadKey();
        }
    }
}

