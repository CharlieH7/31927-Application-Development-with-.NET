using System;

/*
  Write a program to create a MathOperation class with static methods for:
  1. Addtion
  2. Substration
  3. Multiplication
  4. Division
  5. Modulus 
  Operations on two integer.
  Use Multi-cast delegate to execute all the operations and remove some operations on two 
  integer numbers: 4 and 5
 
 */
namespace Week10Program1
{
    //  Write code here to Create a delegate
    public delegate void mathop(int n1, int n2);

    // Write code here to Create the MathOperation class
    class MathOperations
    {
        // Method to add two integers
        public static void add(int n1, int n2)
        {
            Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1 + n2));
        }
        //Write code here for the Method to substract two integers
        public static void subtract(int n1, int n2)
        {
            Console.WriteLine("{0} - {1} = {2}", n1, n2, (n1 - n2));
        }
        // Write code here to the Method to multiple two integers
        public static void multiply(int n1, int n2)
        {
            Console.WriteLine("{0} x {1} = {2}", n1, n2, (n1 * n2));
        }
        // Write code here to the Method to divide two integers
        public static void divide(int n1, int n2)
        {
            Console.WriteLine("{0} / {1} = {2}", n1, n2, (n1 / n2));
        }
        // Write code here to the Method to calculate the modulus two integers
        public static void modulus(int n1, int n2)
        {
            Console.WriteLine("{0} % {1} = {2}", n1, n2, (n1 % n2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Write code here to Create an instance of the delegate
            mathop operation = new mathop(MathOperations.add);

            // Write code here to Add all operations to the delegate
            operation += MathOperations.subtract;
            operation += MathOperations.multiply;
            operation += MathOperations.divide;
            operation += MathOperations.modulus;


            Console.WriteLine("Executing the Multicast Delegate:");
            operation(5, 4);

            Console.WriteLine("\nExecuting the Multicast Delegate after removing some operations:");
            // Write code here to Remove mul, and sub from the delegate
            operation -= MathOperations.subtract;
            operation -= MathOperations.modulus;


            operation(5, 4);

            Console.ReadKey();
        }
    }
}
/*
Test case:

Executing the Multicast Delegate:
5 + 4 = 9
5 - 4 = 1
5 X 4 = 20
5 / 4 = 1
5 % 4 = 1

Executing the Multicast Delegate after removing some operations:
5 + 4 = 9
5 X 4 = 20
5 / 4 = 1
*/