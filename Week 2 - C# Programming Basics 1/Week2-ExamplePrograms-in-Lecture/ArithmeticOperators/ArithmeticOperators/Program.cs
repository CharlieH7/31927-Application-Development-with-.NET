using System;

namespace Week2Programs
{
    class ArithmeticOperatoDemo
    {
        // The Program Shows a demo on the Arithematic Operator usage

        static void Main(string[] args)
        {
            // Variable declaration
            int sum, product, diff, modulo;
            float divResult;
            int X = 10, Y = 20;

            // Perform the Arithematic operations
            sum = X + Y;
            diff = X - Y;
            product = X * Y;
            divResult =  X/Y;
            modulo = X % Y;
            
            // Display results
            Console.WriteLine("{0} + {1} = {2}", X, Y, sum);
            Console.WriteLine("{0} - {1} = {2}", X, Y, diff);
            Console.WriteLine("{0} * {1} = {2}", X, Y, product);
            Console.WriteLine("{0} / {1} = {2}", X, Y, divResult);
            Console.WriteLine("{0} % {1} = {2}", X, Y, modulo);
            Console.Read();            
        }
    }
}


