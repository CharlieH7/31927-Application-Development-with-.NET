using System;
// Program to demonstrate
// Enums

namespace Week2Programs
{
    class EnumDemo
    {
        enum Priority
        {
            Basic,
            Intermediate,
            High,
            Veryhigh
        }
        static void Main(string[] args)
        {
            // Create an enum variable 
            Priority PriorityValue = Priority.High;

            //Check for the enum values
            if(PriorityValue == Priority.Veryhigh)
            {
                Console.WriteLine("Solve the issue in 1 hours");
            }
            else if(PriorityValue == Priority.Intermediate)
            {
                Console.WriteLine("Solve the issue in 12 hours");
            }
            else if (PriorityValue == Priority.High)
            {
                Console.WriteLine("Solve the issue in 4 hours");
            }
            else if (PriorityValue == Priority.Basic)
            {
                Console.WriteLine("Solve the issue in 48 hours");
            }

            Console.Read();
        }
    }
}



