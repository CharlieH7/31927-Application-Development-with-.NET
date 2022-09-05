using System;
/*
Program to display all odd number 
between 1 to 10, using for loop
*/

namespace Week2Programs
{
    class ForLoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The odd numbers between 1 to 10 are:");

            //For loop starts here -->
            // 1. initial the loop control variable
            // 2. add terminating condition
            // 3. increment
            for(int controlVar=1; controlVar<=10; controlVar++)
            {
                // Check for odd number
                if(controlVar%2 != 0)
                {
                    Console.Write(controlVar + ",");
                }
            }
            Console.Read();
        }
    }
}



