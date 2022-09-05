using System;
/*
Diaplay all even number between 1 to 10 
using do...while loop
*/

namespace Week2Programs
{
    class doWhileDemo
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int controlVar = 1;
            Console.WriteLine("The even number between 1 and 10 are:");

            // do...while loop starts here
            do
            {
                if (controlVar % 2 == 0)
                {
                    Console.Write(controlVar + ",");
                }

                // IMPORTANT: increment the loop control variable 
                // to avoid creating an infinite loop!
                controlVar++;
            } while (controlVar <= 10);

            Console.Read();
        }
    }
}


