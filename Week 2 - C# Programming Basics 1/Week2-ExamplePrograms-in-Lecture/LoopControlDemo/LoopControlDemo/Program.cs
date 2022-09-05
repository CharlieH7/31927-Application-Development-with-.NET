using System;
/*
Write a program to print all
number between 1 to 10
except 3, 4 and 9
*/

namespace Week2Programs
{
    class LoopControlDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers are:");
            // Initialize the for loop here
            for(int controlVar =1; controlVar <=10; controlVar++)
            {
                // Skipping numbers 3, 4, and 9 from displaying.
                if(controlVar==3 || controlVar==4 || controlVar == 9)
                {
                    continue;
                    // Continue skips the printing and 
                    // resumes the loop execution from 
                    // next iteration
                }
                // Display the numbers
                Console.Write(controlVar + ",");
            }

            Console.Read();
        }
    }
}


