using System;
// Program to demonstrate
// reading numeric input from user

namespace Week2Programs
{
    class InputOutputDemo
    {
        static void Main(string[] args)
        {
            // Initialize variables
            string userInput;
            int intValue;
            double doubleValue;

            // Display instructions for the user
            Console.Write("Enter an integer value: ");
            // Read the user input
            userInput = Console.ReadLine();
            // Converts to integer 
            intValue = Convert.ToInt32(userInput);
            Console.WriteLine("You have entered {0}", intValue);

            // For double values
            Console.Write("Enter a double value: ");
            userInput = Console.ReadLine();
            /* Converts to double type */
            doubleValue = Convert.ToDouble(userInput);
            Console.WriteLine("You have entered {0}", doubleValue);

            Console.ReadKey();            
        }
    }
}
