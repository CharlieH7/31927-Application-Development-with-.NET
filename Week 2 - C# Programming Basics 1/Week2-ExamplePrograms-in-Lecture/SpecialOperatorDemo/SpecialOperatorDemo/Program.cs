using System;
// The Programs shows a demo on Special operators

namespace Week2Programs
{
    class SpecialOperatorDemo
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int number1 = 10, number2 = 15;

            // Check the size using sizeof()
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of bool is {0}", sizeof(bool));

            // Find the highest number using ternary operator 
            // and display the result
            int highestNumber = number1 > number2 ? number1 : number2;
            Console.WriteLine("The numbers are {0} and {1}", number1, number2);
            Console.WriteLine("The higest number is {0}", highestNumber);
            Console.Read();
        }
    }
}


