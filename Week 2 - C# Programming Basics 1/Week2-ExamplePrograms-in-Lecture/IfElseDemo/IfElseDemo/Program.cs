using System;
/*
 Program to Check whether a number is even or odd or
 equals to zero
*/

namespace Week2Programs
{
    class IfElseDemo
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int numberToCheck = 10;

            // Check if the number of even or odd and 
            // Display the result
            if(numberToCheck == 0)
            {
                Console.WriteLine("The number is zero!");
            }
            else if (numberToCheck % 2 == 0)
            {
                Console.WriteLine("The Number is even!");            
            }            
            else
            {
                Console.WriteLine("The Number is odd!");
            }
            Console.Read();
        }
    }
}

