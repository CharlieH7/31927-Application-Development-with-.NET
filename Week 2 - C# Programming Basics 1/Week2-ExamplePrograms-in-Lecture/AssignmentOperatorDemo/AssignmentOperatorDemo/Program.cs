using System;
// The Program shows a demo on assignment operators

namespace Week2Programs
{
    class AssignmentOperatorDemo
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int number = 10;         

            // Display the results of 
            // various assignment operation
            Console.WriteLine("Number = {0}", number);

            number += 5;
            Console.WriteLine("Number after += operation = {0}", number);

            number -= 5;
            Console.WriteLine("Number after -= operation = {0}", number);

            number *= 5;
            Console.WriteLine("Number after *= operation = {0}", number);

            number /= 5;
            Console.WriteLine("Number after /= operation = {0}", number);

            number %= 5;
            Console.WriteLine("Number after += operation = {0}", number);

            Console.Read();
        }
    }
}


