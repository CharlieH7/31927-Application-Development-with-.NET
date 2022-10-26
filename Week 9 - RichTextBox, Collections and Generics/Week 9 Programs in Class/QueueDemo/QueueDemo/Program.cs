using System;
using System.Collections;

namespace Week9ClassProgram
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            // Create a ticket queue for banks
            Queue ticketQueue = new Queue();

            // Add some ticket into the queue
            ticketQueue.Enqueue("120");
            ticketQueue.Enqueue("125");
            ticketQueue.Enqueue("129");
            ticketQueue.Enqueue("A");
            ticketQueue.Enqueue("B");
            ticketQueue.Enqueue("AB");

            // Display the current queue status
            foreach(string ticketno in ticketQueue)
            {
                Console.Write(ticketno + " ");
            }

            // Display the currently processed ticket
            Console.WriteLine("\n\nThe currently processed ticket is :{0}", ticketQueue.Dequeue().ToString());

            Console.ReadKey();            
        }
    }
}
