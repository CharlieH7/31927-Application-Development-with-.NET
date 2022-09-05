using System;
/*
Write a program to create a number triangle, e.g:
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
*/

namespace Week2Programs
{
    class NestedLoopDemo
    {
        static void Main(string[] args)
        {
            //Initialize the outer loop
            for(int outerLoop=1; outerLoop<=5; outerLoop++)
            {
                // Outer loop body
                // Initialize the inner loop
                for(int innerLoop=1; innerLoop<=outerLoop; innerLoop++)
                {
                    // Inner loop body
                    // Print the numbers and a space
                    Console.Write(innerLoop + " ");
                } // Inner loop end
                // Transfer the conrol to next line for printing.
                Console.WriteLine();
            }// Outer loop end

            Console.Read();
        }
    }
}



