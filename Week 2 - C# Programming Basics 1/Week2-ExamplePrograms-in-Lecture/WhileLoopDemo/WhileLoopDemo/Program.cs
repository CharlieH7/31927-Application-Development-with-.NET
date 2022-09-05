using System;
/*
Program to display all odd numbers 
between 1 to 10, using While loop
*/

namespace Week2Program
{
    class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int controlVar = 1;

            Console.WriteLine("The odd number between 1 and 10 are:");
            // While loop starts here -->
            while (controlVar <= 10)
            {
                // Check for odd number
                if(controlVar % 2 != 0)
                {
                    Console.Write(controlVar + ",");                    
                }

                // Increment the loop control variable
                controlVar++;
            }
            Console.Read();
        }
    }
}


