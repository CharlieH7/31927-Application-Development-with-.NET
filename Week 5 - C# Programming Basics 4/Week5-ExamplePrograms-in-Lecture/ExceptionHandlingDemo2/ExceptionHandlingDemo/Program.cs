using System;
// Exception Handling demo to illustate throw
// Create a list of students and write them into 
// an exixsting file 
namespace Week5ClassProgram
{
    class ExceptionHandlingDemo2
    {
        static void Main(string[] args)
        {
            int number1, number2;
            double result;
            // Accept two number from user
            Console.Write("Enter the first number:");
            string userInput = Console.ReadLine();
            number1 = Convert.ToInt32(userInput);

            Console.Write("Enter the second number:");
            userInput = Console.ReadLine();
            number2 = Convert.ToInt32(userInput);
            
            // dividing two numbers might have a division by zero error
            // hence run it inside a try block
            try
            {
                if (number2 == 0)
                {
                    throw new Exception("My Division by Zero exception");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine("Result is: {0}", result);
                }
                
            }
            // If number2 is zero as exception will be created
            catch(DivideByZeroException e)
            {
                Console.WriteLine("The Error is '{0}'", e);
            }
            catch(Exception e)
            {
                Console.WriteLine("The Error is '{0}'", e);
            }
            // Always executed
            finally
            {
                Console.WriteLine("Bye bye... I cleaned the memmory!");
            }
            
            Console.ReadKey();
        }
    }
}
